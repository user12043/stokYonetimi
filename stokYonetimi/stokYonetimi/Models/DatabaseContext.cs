namespace stokYonetimi.Models {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseContext : DbContext {
        public DatabaseContext()
            : base("name=DatabaseContext") {
        }

        public virtual DbSet<Fatura> faturalar { get; set; }
        public virtual DbSet<Kisi> kisiler { get; set; }
        public virtual DbSet<Musteri> musteriler { get; set; }
        public virtual DbSet<Personel> personeller { get; set; }
        public virtual DbSet<Siparis> siparisler { get; set; }
        public virtual DbSet<Stok> stoklar { get; set; }
        public virtual DbSet<Urun> urunler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Fatura>()
                .HasMany(e => e.siparisler)
                .WithRequired(e => e.Fatura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musteri>()
                .HasMany(e => e.faturalar)
                .WithRequired(e => e.Musteri)
                .HasForeignKey(e => e.musteriId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musteri>()
                .HasMany(e => e.siparisler)
                .WithRequired(e => e.Musteri)
                .HasForeignKey(e => e.musteriId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.siparisler)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.stoklar)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);
        }
    }
}