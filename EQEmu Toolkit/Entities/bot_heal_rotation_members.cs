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
    
    public partial class bot_heal_rotation_members
    {
        public long member_index { get; set; }
        public long heal_rotation_index { get; set; }
        public long bot_id { get; set; }
    
        public virtual bot_data bot_data { get; set; }
        public virtual bot_heal_rotations bot_heal_rotations { get; set; }
    }
}
