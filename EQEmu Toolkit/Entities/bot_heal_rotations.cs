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
    
    public partial class bot_heal_rotations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bot_heal_rotations()
        {
            this.bot_heal_rotation_members = new HashSet<bot_heal_rotation_members>();
            this.bot_heal_rotation_targets = new HashSet<bot_heal_rotation_targets>();
        }
    
        public long heal_rotation_index { get; set; }
        public long bot_id { get; set; }
        public long interval { get; set; }
        public long fast_heals { get; set; }
        public long adaptive_targeting { get; set; }
        public long casting_override { get; set; }
    
        public virtual bot_data bot_data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bot_heal_rotation_members> bot_heal_rotation_members { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bot_heal_rotation_targets> bot_heal_rotation_targets { get; set; }
    }
}