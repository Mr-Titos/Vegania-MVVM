namespace DevellopementCursor.Modele
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Donnees : DbContext
    {
        public Donnees()
            : base("name=Donnees1")
        {
        }

        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<categories> categories { get; set; }
        public virtual DbSet<clients> clients { get; set; }
        public virtual DbSet<commandes> commandes { get; set; }
        public virtual DbSet<detailcommandes> detailcommandes { get; set; }
        public virtual DbSet<produits> produits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<admin>()
                .Property(e => e.Mdp)
                .IsUnicode(false);

            modelBuilder.Entity<categories>()
                .Property(e => e.LIB_CATEGORIE)
                .IsUnicode(false);

            modelBuilder.Entity<categories>()
                .HasMany(e => e.produits)
                .WithRequired(e => e.categories)
                .HasForeignKey(e => e.NumCat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.NOM_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.ADR_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.CP_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.VIL_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.TEL_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.EMAIL_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.LOG_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .Property(e => e.MDP_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<clients>()
                .HasMany(e => e.commandes)
                .WithRequired(e => e.clients)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<commandes>()
                .Property(e => e.ADR_LIVRAISON)
                .IsUnicode(false);

            modelBuilder.Entity<commandes>()
                .Property(e => e.ETAT_COM)
                .IsUnicode(false);

            modelBuilder.Entity<commandes>()
                .HasMany(e => e.detailcommandes)
                .WithRequired(e => e.commandes)
                .HasForeignKey(e => e.IdCommande)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<produits>()
                .Property(e => e.LibProd)
                .IsUnicode(false);

            modelBuilder.Entity<produits>()
                .Property(e => e.DescProd)
                .IsUnicode(false);

            modelBuilder.Entity<produits>()
                .HasMany(e => e.detailcommandes)
                .WithRequired(e => e.produits)
                .WillCascadeOnDelete(false);
        }
    }
}
