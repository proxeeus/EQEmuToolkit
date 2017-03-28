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
    
    public partial class bot_data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bot_data()
        {
            this.bot_buffs = new HashSet<bot_buffs>();
            this.bot_group_members = new HashSet<bot_group_members>();
            this.bot_groups = new HashSet<bot_groups>();
            this.bot_heal_rotation_members = new HashSet<bot_heal_rotation_members>();
            this.bot_heal_rotations = new HashSet<bot_heal_rotations>();
            this.bot_inventories = new HashSet<bot_inventories>();
            this.bot_pets = new HashSet<bot_pets>();
        }
    
        public long bot_id { get; set; }
        public long owner_id { get; set; }
        public long spells_id { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string title { get; set; }
        public string suffix { get; set; }
        public short zone_id { get; set; }
        public sbyte gender { get; set; }
        public short race { get; set; }
        public sbyte @class { get; set; }
        public byte level { get; set; }
        public long deity { get; set; }
        public long creation_day { get; set; }
        public long last_spawn { get; set; }
        public long time_spawned { get; set; }
        public float size { get; set; }
        public int face { get; set; }
        public int hair_color { get; set; }
        public int hair_style { get; set; }
        public int beard { get; set; }
        public int beard_color { get; set; }
        public int eye_color_1 { get; set; }
        public int eye_color_2 { get; set; }
        public int drakkin_heritage { get; set; }
        public int drakkin_tattoo { get; set; }
        public int drakkin_details { get; set; }
        public short ac { get; set; }
        public int atk { get; set; }
        public int hp { get; set; }
        public int mana { get; set; }
        public int str { get; set; }
        public int sta { get; set; }
        public int cha { get; set; }
        public int dex { get; set; }
        public int @int { get; set; }
        public int agi { get; set; }
        public int wis { get; set; }
        public short fire { get; set; }
        public short cold { get; set; }
        public short magic { get; set; }
        public short poison { get; set; }
        public short disease { get; set; }
        public short corruption { get; set; }
        public long show_helm { get; set; }
        public long follow_distance { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bot_buffs> bot_buffs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bot_group_members> bot_group_members { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bot_groups> bot_groups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bot_heal_rotation_members> bot_heal_rotation_members { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bot_heal_rotations> bot_heal_rotations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bot_inventories> bot_inventories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bot_pets> bot_pets { get; set; }
        public virtual bot_stances bot_stances { get; set; }
        public virtual bot_timers bot_timers { get; set; }
    }
}