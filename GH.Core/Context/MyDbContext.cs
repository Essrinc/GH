using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GH.Core.Entities
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDbContext")
        {
        }

        public virtual DbSet<Aktivite> Aktivites { get; set; }
        public virtual DbSet<Arama> Aramas { get; set; }
        public virtual DbSet<Icerik> Iceriks { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<KullaniciAktivite> KullaniciAktivites { get; set; }
        public virtual DbSet<KullaniciFavoriListe> KullaniciFavoriListes { get; set; }
        public virtual DbSet<KullaniciUrunFavoriListe> KullaniciUrunFavoriListes { get; set; }
        public virtual DbSet<KullaniciUrunIcerikKaraListe> KullaniciUrunIcerikKaraListes { get; set; }
        public virtual DbSet<OnayDurum> OnayDurums { get; set; }
        public virtual DbSet<RiskSeviye> RiskSeviyes { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolYetki> RolYetkis { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Uretici> Ureticis { get; set; }
        public virtual DbSet<Urun> Uruns { get; set; }
        public virtual DbSet<UrunDuzeltmeTalep> UrunDuzeltmeTaleps { get; set; }
        public virtual DbSet<UrunIcerik> UrunIceriks { get; set; }
        public virtual DbSet<UrunOnayDurum> UrunOnayDurums { get; set; }
        public virtual DbSet<Yetki> Yetkis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aktivite>()
                .HasMany(e => e.KullaniciAktivites)
                .WithRequired(e => e.Aktivite)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Icerik>()
                .HasMany(e => e.KullaniciUrunIcerikKaraListes)
                .WithRequired(e => e.Icerik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Icerik>()
                .HasMany(e => e.UrunIceriks)
                .WithRequired(e => e.Icerik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.Uruns)
                .WithRequired(e => e.Kategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Aramas)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.KullaniciAktivites)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.KullaniciFavoriListes)
                .WithRequired(e => e.Kullanici)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.KullaniciUrunIcerikKaraListes)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KullaniciFavoriListe>()
                .HasMany(e => e.KullaniciUrunFavoriListes)
                .WithRequired(e => e.KullaniciFavoriListe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OnayDurum>()
                .HasMany(e => e.UrunDuzeltmeTaleps)
                .WithRequired(e => e.OnayDurum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OnayDurum>()
                .HasMany(e => e.UrunOnayDurums)
                .WithRequired(e => e.OnayDurum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RiskSeviye>()
                .HasMany(e => e.Iceriks)
                .WithRequired(e => e.RiskSeviye)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Kullanicis)
                .WithOptional(e => e.Rol)
                .HasForeignKey(e => e.RolIdD);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.RolYetkis)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Uretici>()
                .HasMany(e => e.Uruns)
                .WithRequired(e => e.Uretici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.Aramas)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.KullaniciUrunFavoriListes)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.UrunDuzeltmeTaleps)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.UrunIceriks)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.UrunOnayDurums)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yetki>()
                .HasMany(e => e.RolYetkis)
                .WithRequired(e => e.Yetki)
                .WillCascadeOnDelete(false);
        }
    }
}
