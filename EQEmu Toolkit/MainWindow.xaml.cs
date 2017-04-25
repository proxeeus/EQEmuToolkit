using EQEmu_Toolkit.Entities;
using HtmlAgilityPack;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace EQEmu_Toolkit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bot_spells_entries bot_spells_context;
        public MainWindow()
        {
            
            InitializeComponent();

           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var document = XDocument.Load(@"C:\Users\LENOVO\Desktop\export_merchants.xml");
            var rows = document.Descendants("row");
            var count = rows.Count();
            var htmlWeb = new HtmlWeb();
            foreach (var row in rows)
            {
                var merchant_name = row.Elements("field").Where(a => a.Attribute("name").Value == "name").Select(p => p.Value).FirstOrDefault();
                //var merchant_name = "Vacto_Molunel";
                var htmlDoc = htmlWeb.Load(string.Concat(
                "http://wiki.project1999.com/",
                merchant_name));

                var uls = htmlDoc.DocumentNode
              .Descendants("div").Where(d =>
       d.Attributes.Contains("class") &&
        d.Attributes["class"].Value.Contains("mobPageDiv"));

                //
                //<span class="mw-headline" id="Items_Sold"> 
                var toto = htmlDoc.DocumentNode.SelectSingleNode("//span[@id='Items_Sold']");
                HtmlNode toto2 = null;
                HtmlNodeCollection toto3 = null;
                //var toto2 = toto.ParentNode.NextSibling.NextSibling.SelectNodes("//li");
                if(toto != null)
                     toto2 = toto.ParentNode.NextSibling.SelectSingleNode("//ul");
                if(toto2 != null)
                     toto3 = toto2.ChildNodes;
                //  var uls = htmlDoc.DocumentNode
                //.SelectNodes("//ul")
                //.Where(a => a.Descendants().Any(b => b.InnerHtml == "span"));

                //         var uls = htmlDoc.DocumentNode
                //       .Descendants("span").Where(d =>
                //d.Attributes.Contains("id") &&
                // d.Attributes["id"].Value.Contains("Items_Sold"));

                try
                {
                    //if (uls.Count() > 0)
                    if (toto3 != null && toto3.Count() > 0)
                    {
                        //foreach (var li in uls.ElementAt(0).ChildNodes)
                        foreach(var li in toto3)
                        {
 
                                if (li.InnerHtml.Contains(@"None"))
                                    break;
                                var links = li.Descendants("a")
                                 .Select(a => a.InnerText)
                                 .ToList();
                               // if (links.Count() == 0) continue;
                                if (links.Count() > 0)
                                {
                                    foreach (var item in links)
                                    {
                                        //Ajout de chaque item dans le row courant
                                        var item_row = new XElement("field", new XAttribute("name", "item_name"));
                                        item_row.Value = item.ToString();
                                        row.Add(item_row);
                                    }
                                    //break;
                                }
                            
                        }
                    }
                }
                finally
                {
                   
                }
                //
            }
            document.Save(@"C:\Users\LENOVO\Desktop\export_merchants_P99_FIX1.xml");
            MessageBox.Show("Done !");
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var document = XDocument.Load(addItemsTextBox.Text);
            var merchant_rows = document.Descendants("row");

            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(@"server=localhost;user id=root;password=eqemu;database=axclassic;persistsecurityinfo=True"))
            {

                connection.Open();
                foreach (var merchant_row in merchant_rows)
                {
                    var item_names = merchant_row.Elements("field").Where(a => a.Attribute("name").Value == "item_name");
                    
                    foreach(var item in item_names)
                    {
                        MySqlDataReader result = null;
                        try
                        {
                            var item_name = item.Value;
                            var entries = new List<string>();
                            var mysqlQuery = string.Format(@"select id, name from items where name=""{0}""", item_name);
                            var command = new MySql.Data.MySqlClient.MySqlCommand(mysqlQuery, connection);
                            result = command.ExecuteReader();

                            var fieldcount = result.FieldCount;
                            //for(var i = 0; i < fieldcount; i++)
                            //{
                            while (result.Read())
                            {
                                if (result[0] != null)
                                {
                                    item.Add(new XAttribute("item_id", result[0].ToString()));
                                }
                                break;
                            }
                        }
                        finally
                        {
                            result.Close();
                            result.Dispose();
                        }
                        //}
                    }
                }
                document.Save(@"C:\Users\LENOVO\Desktop\export_merchants_P99_FIX2_ITEMS.xml");
                MessageBox.Show("Done !");
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            var document = XDocument.Load(generateSQLTextBox.Text);
            var merchant_rows = document.Descendants("row");
            var startIndex = 500000;
            var queryBuilder = new StringBuilder();

            queryBuilder.Append("-- This script has been generated by a tool.\n");
            queryBuilder.Append("-- =========================================\n");
            queryBuilder.Append(string.Format("-- New merchantlist entries will start at id: {0}.\n", startIndex));
            queryBuilder.Append("\n");
            
            foreach (var merchant_row in merchant_rows)
            {
                var merchantid = merchant_row.Elements("field").Where(a => a.Attribute("name").Value == "merchantid").Select(p => p.Value).FirstOrDefault();
                var npcid = merchant_row.Elements("field").Where(a => a.Attribute("name").Value == "id").Select(p => p.Value).FirstOrDefault();
                var merchantname = merchant_row.Elements("field").Where(a => a.Attribute("name").Value == "name").Select(p => p.Value).FirstOrDefault();

                var item_names = merchant_row.Elements("field").Where(a => a.Attribute("name").Value == "item_name");
                int itemslot = 0;
                if (item_names.Count() > 0 )
                {
                    queryBuilder.Append(string.Format("-- Generating SQL for {0} (id: {1}, merchantid: {2}).", merchantname, npcid, merchantid));
                    queryBuilder.Append("\n");
                    queryBuilder.Append(string.Format("delete from merchantlist where merchantid={0};", startIndex));

                    itemslot = 1;
                    foreach (var itemname in item_names)
                    {
                        var itemid = "-1";
                        if (itemname.Attribute("item_id") != null)
                            itemid = itemname.Attribute("item_id").Value;
                        else continue;
                        var insertquery = string.Format("insert into merchantlist values ('{0}', '{1}', '{2}', '-1100', '0', '0', '65535', '100');",
                            startIndex, itemslot, itemid);

                        queryBuilder.Append("\n");
                        queryBuilder.Append(insertquery);
                        itemslot++;
                    }
                    queryBuilder.Append("\n");
                    queryBuilder.Append(string.Format("update npc_types set merchant_id={0} where id={1};", startIndex, npcid));
                    itemslot = 0;
                    queryBuilder.Append("\n");
                    queryBuilder.Append("-- =========================================\n");
                    queryBuilder.Append("\n");
                }
                else continue;
                startIndex++;
            }
            startIndex = 50000;
            
            using (var writer = new StreamWriter(@"C:\Users\LENOVO\Desktop\merchantlist.sql"))
            {
                writer.Write(queryBuilder.ToString());
            }

            MessageBox.Show("Done !");
        }
    }
}
