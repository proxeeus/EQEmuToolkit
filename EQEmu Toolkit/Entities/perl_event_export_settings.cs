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
    
    public partial class perl_event_export_settings
    {
        public int event_id { get; set; }
        public string event_description { get; set; }
        public Nullable<short> export_qglobals { get; set; }
        public Nullable<short> export_mob { get; set; }
        public Nullable<short> export_zone { get; set; }
        public Nullable<short> export_item { get; set; }
        public Nullable<short> export_event { get; set; }
    }
}