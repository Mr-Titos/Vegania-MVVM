namespace DevellopementCursor.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebook.produits")]
    public partial class produits
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produits()
        {
            detailcommandes = new HashSet<detailcommandes>();
        }

        [Key]
        public int IdProd { get; set; }

        public int NumCat { get; set; }

        [Required]
        [StringLength(25)]
        public string LibProd { get; set; }

        public double PrixProd { get; set; }

        public int QteProd { get; set; }

        [Required]
        [StringLength(150)]
        public string DescProd { get; set; }

        public virtual categories categories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detailcommandes> detailcommandes { get; set; }
    }
}
