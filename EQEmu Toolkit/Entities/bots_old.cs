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
    
    public partial class bots_old
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bots_old()
        {
            this.botbuffs___ = new HashSet<botbuffs___>();
            this.botgroup_old = new HashSet<botgroup_old>();
            this.botgroupmembers_old = new HashSet<botgroupmembers_old>();
            this.botinventory_old = new HashSet<botinventory_old>();
            this.botpets_old = new HashSet<botpets_old>();
        }
    
        public long BotID { get; set; }
        public long BotOwnerCharacterID { get; set; }
        public long BotSpellsID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte BotLevel { get; set; }
        public short Race { get; set; }
        public sbyte Class { get; set; }
        public sbyte Gender { get; set; }
        public float Size { get; set; }
        public int Face { get; set; }
        public int LuclinHairStyle { get; set; }
        public int LuclinHairColor { get; set; }
        public int LuclinEyeColor { get; set; }
        public int LuclinEyeColor2 { get; set; }
        public int LuclinBeardColor { get; set; }
        public int LuclinBeard { get; set; }
        public int DrakkinHeritage { get; set; }
        public int DrakkinTattoo { get; set; }
        public int DrakkinDetails { get; set; }
        public int HP { get; set; }
        public int Mana { get; set; }
        public short MR { get; set; }
        public short CR { get; set; }
        public short DR { get; set; }
        public short FR { get; set; }
        public short PR { get; set; }
        public short Corrup { get; set; }
        public short AC { get; set; }
        public int STR { get; set; }
        public int STA { get; set; }
        public int DEX { get; set; }
        public int AGI { get; set; }
        public int C_INT { get; set; }
        public int WIS { get; set; }
        public int CHA { get; set; }
        public int ATK { get; set; }
        public System.DateTime BotCreateDate { get; set; }
        public System.DateTime LastSpawnDate { get; set; }
        public long TotalPlayTime { get; set; }
        public short LastZoneId { get; set; }
        public string BotInspectMessage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<botbuffs___> botbuffs___ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<botgroup_old> botgroup_old { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<botgroupmembers_old> botgroupmembers_old { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<botinventory_old> botinventory_old { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<botpets_old> botpets_old { get; set; }
        public virtual botstances_old botstances_old { get; set; }
        public virtual bottimers_old bottimers_old { get; set; }
    }
}