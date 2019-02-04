namespace DevellopementCursor.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebook.clients")]
    public partial class clients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clients()
        {
            commandes = new HashSet<commandes>();
        }

        [Key]
        public int NUM_CLIENT { get; set; }

        [Required]
        [StringLength(100)]
        public string NOM_CLIENT { get; set; }

        [Required]
        [StringLength(255)]
        public string ADR_CLIENT { get; set; }

        [Required]
        [StringLength(6)]
        public string CP_CLIENT { get; set; }

        [Required]
        [StringLength(255)]
        public string VIL_CLIENT { get; set; }

        [Column(TypeName = "date")]
        public DateTime NAI_CLIENT { get; set; }

        [Required]
        [StringLength(10)]
        public string TEL_CLIENT { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL_CLIENT { get; set; }

        public bool? Partenaire { get; set; }

        [Required]
        [StringLength(100)]
        public string LOG_CLIENT { get; set; }

        [Required]
        [StringLength(100)]
        public string MDP_CLIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commandes> commandes { get; set; }
    }
}
