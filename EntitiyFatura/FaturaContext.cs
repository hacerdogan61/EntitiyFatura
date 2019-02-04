using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace EntitiyFatura
{
   public class FaturaContext:DbContext
    {
        public FaturaContext():base("Baglanti")
        {

        }
        public virtual DbSet<FaturaMaster> FaturaMaster { get; set; }
        public virtual DbSet<FaturaDetay> FaturaDetay { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<Birimler> Birimler { get; set; }
        public virtual DbSet<Il> iller { get; set; }
        public virtual DbSet<Ilce> ilceler { get; set; }
    }
    [Table ("Il")]
    public class Il
    {
        public Il()
        {
            this.ilce = new HashSet<Ilce>();
        }
        [Key]
        public int Id { get; set; }
        public string IlAdi { get; set; }
        public virtual ICollection<Ilce> ilce { get; set; }

    }
    [Table("Ilce")]
    public class Ilce
    {
        public Ilce()
        {
            this.urun = new HashSet<Urun>();
        }
        [Key]
        public int Ilceid { get; set; }
        public string IlceAdi { get; set; }
        public int Ilid { get; set; }
        public virtual Il il{get;set;}
        public virtual ICollection<Urun> urun { get; set; }

    }
    [Table("Urun")]
    public class Urun
    {
        public Urun()
        {
            this.faturaDetay = new HashSet<FaturaDetay>();

        }
        [Key]
        public int Urunid { get; set; }
        public string UrunAdi { get; set; }
        public string UrunKodu { get; set; }
        public int BirimID { get; set; }
        public decimal BirimFiyat { get; set; }
        public virtual ICollection<FaturaDetay> faturaDetay { get; set; }
        public virtual Birimler birim { get; set; }


    }
    [Table("Birim")]
    public class Birimler
    {
        public Birimler()
        {
            this.urun = new HashSet<Urun>();
        }
        [Key]
        public int Birimid { get; set; }
        public string BirimAdi { get; set; }
        public virtual ICollection<Urun> urun{ get; set; }


    }
    [Table("Musteri")]
    public class Musteri
    {
        public Musteri()
        {
            this.FaturaMaster = new HashSet<FaturaMaster>();
        }
        [Key]
        public int MusteriId { get; set; }
        public string MusteriUnvani { get; set; }
        public int IlceId { get; set; }
        public string MusteriAdresi { get; set; }
        public virtual Ilce ilce { get; set; }
        public  virtual ICollection<FaturaMaster> FaturaMaster { get; set; }

    }
    [Table("FaturaMater")]
    public class FaturaMaster
    {
        public FaturaMaster()
        {
            this.detay = new HashSet<FaturaDetay>();
            this.FaturaTarihi = DateTime.Now;
        }
        [Key]
        public int FaturaID { get; set; }
        public int MusteriID { get; set; }
        public int IrsaliyeNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public DateTime OdemeTarihi
        {
            get; set;
        }
        public virtual Musteri musteri { get; set; }
        public virtual ICollection<FaturaDetay > detay { get; set; }
    }
    [Table("FaturaDetay")]
    public class FaturaDetay
    {
        public FaturaDetay()
        {
            this.Aciklama = "Vadesinden sonra ödenen  faturalara %5 kanuni ceza faizi uygulanır.";
      
        }
        [Key][Column(Order =0)]
        public int FaturaId { get; set; }
        [Key]
        [Column(Order = 1)]
        public int UrunID { get; set; }
        public decimal Miktar { get; set; }
        public decimal TopkamFiyat { get; set; }
        public decimal KDV { get; set; }
        public decimal KDVliFiyat { get; set; }
        public decimal FaturaToplami { get; set; }
        public  virtual FaturaMaster Faturamaster { get; set; }
        public virtual Urun urun { get; set; }
        public string Aciklama { get;  set; }
    }

}
