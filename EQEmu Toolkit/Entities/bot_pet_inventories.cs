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
    
    public partial class bot_pet_inventories
    {
        public long pet_inventories_index { get; set; }
        public long pets_index { get; set; }
        public long item_id { get; set; }
    
        public virtual bot_pets bot_pets { get; set; }
    }
}