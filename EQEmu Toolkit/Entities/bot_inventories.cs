//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EQEmu_Toolkit.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class bot_inventories
    {
        public long inventories_index { get; set; }
        public long bot_id { get; set; }
        public int slot_id { get; set; }
        public Nullable<long> item_id { get; set; }
        public Nullable<int> inst_charges { get; set; }
        public long inst_color { get; set; }
        public bool inst_no_drop { get; set; }
        public string inst_custom_data { get; set; }
        public long ornament_icon { get; set; }
        public long ornament_id_file { get; set; }
        public int ornament_hero_model { get; set; }
        public int augment_1 { get; set; }
        public int augment_2 { get; set; }
        public int augment_3 { get; set; }
        public int augment_4 { get; set; }
        public int augment_5 { get; set; }
        public int augment_6 { get; set; }
    
        public virtual bot_data bot_data { get; set; }
    }
}