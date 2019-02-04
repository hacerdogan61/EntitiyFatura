namespace EntitiyFatura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fatura : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Birim",
                c => new
                    {
                        Birimid = c.Int(nullable: false, identity: true),
                        BirimAdi = c.String(),
                    })
                .PrimaryKey(t => t.Birimid);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        Urunid = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(),
                        UrunKodu = c.String(),
                        BirimID = c.Int(nullable: false),
                        BirimFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ilce_Ilceid = c.Int(),
                    })
                .PrimaryKey(t => t.Urunid)
                .ForeignKey("dbo.Birim", t => t.BirimID, cascadeDelete: true)
                .ForeignKey("dbo.Ilce", t => t.Ilce_Ilceid)
                .Index(t => t.BirimID)
                .Index(t => t.Ilce_Ilceid);
            
            CreateTable(
                "dbo.FaturaDetay",
                c => new
                    {
                        FaturaId = c.Int(nullable: false),
                        UrunID = c.Int(nullable: false),
                        Miktar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TopkamFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KDV = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KDVliFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FaturaToplami = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => new { t.FaturaId, t.UrunID })
                .ForeignKey("dbo.FaturaMater", t => t.FaturaId, cascadeDelete: true)
                .ForeignKey("dbo.Urun", t => t.UrunID, cascadeDelete: true)
                .Index(t => t.FaturaId)
                .Index(t => t.UrunID);
            
            CreateTable(
                "dbo.FaturaMater",
                c => new
                    {
                        FaturaID = c.Int(nullable: false, identity: true),
                        MusteriID = c.Int(nullable: false),
                        IrsaliyeNo = c.Int(nullable: false),
                        FaturaTarihi = c.DateTime(nullable: false),
                        OdemeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FaturaID)
                .ForeignKey("dbo.Musteri", t => t.MusteriID, cascadeDelete: true)
                .Index(t => t.MusteriID);
            
            CreateTable(
                "dbo.Musteri",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        MusteriUnvani = c.String(),
                        IlceId = c.Int(nullable: false),
                        MusteriAdresi = c.String(),
                    })
                .PrimaryKey(t => t.MusteriId)
                .ForeignKey("dbo.Ilce", t => t.IlceId, cascadeDelete: true)
                .Index(t => t.IlceId);
            
            CreateTable(
                "dbo.Ilce",
                c => new
                    {
                        Ilceid = c.Int(nullable: false, identity: true),
                        IlceAdi = c.String(),
                        Ilid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ilceid)
                .ForeignKey("dbo.Il", t => t.Ilid, cascadeDelete: true)
                .Index(t => t.Ilid);
            
            CreateTable(
                "dbo.Il",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IlAdi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FaturaDetay", "UrunID", "dbo.Urun");
            DropForeignKey("dbo.Musteri", "IlceId", "dbo.Ilce");
            DropForeignKey("dbo.Urun", "Ilce_Ilceid", "dbo.Ilce");
            DropForeignKey("dbo.Ilce", "Ilid", "dbo.Il");
            DropForeignKey("dbo.FaturaMater", "MusteriID", "dbo.Musteri");
            DropForeignKey("dbo.FaturaDetay", "FaturaId", "dbo.FaturaMater");
            DropForeignKey("dbo.Urun", "BirimID", "dbo.Birim");
            DropIndex("dbo.Ilce", new[] { "Ilid" });
            DropIndex("dbo.Musteri", new[] { "IlceId" });
            DropIndex("dbo.FaturaMater", new[] { "MusteriID" });
            DropIndex("dbo.FaturaDetay", new[] { "UrunID" });
            DropIndex("dbo.FaturaDetay", new[] { "FaturaId" });
            DropIndex("dbo.Urun", new[] { "Ilce_Ilceid" });
            DropIndex("dbo.Urun", new[] { "BirimID" });
            DropTable("dbo.Il");
            DropTable("dbo.Ilce");
            DropTable("dbo.Musteri");
            DropTable("dbo.FaturaMater");
            DropTable("dbo.FaturaDetay");
            DropTable("dbo.Urun");
            DropTable("dbo.Birim");
        }
    }
}
