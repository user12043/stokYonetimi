namespace stokYonetimi.Models {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseContext : DbContext {
        public DatabaseContext()
            : base("name=DatabaseContext") {
        }

        public virtual DbSet<Fatura> Faturalar { get; set; }
        public virtual DbSet<Kisi> Kisiler { get; set; }
        public virtual DbSet<Siparis> Siparisler { get; set; }
        public virtual DbSet<Stok> Stoklar { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Fatura>()
                .HasMany(e => e.Siparisler)
                .WithRequired(e => e.Fatura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.Siparisler)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.Stoklar)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);
        }
    }
}