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
    
    public partial class character_old
    {
        public int id { get; set; }
        public int account_id { get; set; }
        public string name { get; set; }
        public byte[] profile { get; set; }
        public Nullable<long> timelaston { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
        public string zonename { get; set; }
        public byte[] alt_adv { get; set; }
        public short zoneid { get; set; }
        public int instanceid { get; set; }
        public int pktime { get; set; }
        public byte[] inventory { get; set; }
        public long groupid { get; set; }
        public byte[] extprofile { get; set; }
        public sbyte @class { get; set; }
        public int level { get; set; }
        public bool lfp { get; set; }
        public bool lfg { get; set; }
        public string mailkey { get; set; }
    }
}