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
    
    public partial class bot_pets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bot_pets()
        {
            this.bot_pet_buffs = new HashSet<bot_pet_buffs>();
            this.bot_pet_inventories = new HashSet<bot_pet_inventories>();
        }
    
        public long pets_index { get; set; }
        public long spell_id { get; set; }
        public long bot_id { get; set; }
        public string name { get; set; }
        public int mana { get; set; }
        public int hp { get; set; }
    
        public virtual bot_data bot_data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bot_pet_buffs> bot_pet_buffs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bot_pet_inventories> bot_pet_inventories { get; set; }
    }
}