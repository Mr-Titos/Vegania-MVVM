namespace DevellopementCursor.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebook.partenaire")]
    public partial class partenaire
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUM_CLI { get; set; }

        [Required]
        [StringLength(50)]
        public string NIVEAU { get; set; }

        public int POURC_REDUC { get; set; }

        public virtual clients clients { get; set; }
    }
}
