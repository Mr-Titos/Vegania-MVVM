namespace DevellopementCursor.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebook.admin")]
    public partial class admin
    {
        [Key]
        public int IdAdmin { get; set; }

        [Required]
        [StringLength(25)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Mdp { get; set; }
    }
}
