namespace DevellopementCursor.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebook.commandes")]
    public partial class commandes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public commandes()
        {
            detailcommandes = new HashSet<detailcommandes>();
        }

        [Key]
        public int NUM_COM { get; set; }

        public int NUM_CLIENT { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_COM { get; set; }

        [Required]
        [StringLength(255)]
        public string ADR_LIVRAISON { get; set; }

        [Required]
        [StringLength(100)]
        public string ETAT_COM { get; set; }

        public virtual clients clients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detailcommandes> detailcommandes { get; set; }
    }
}
