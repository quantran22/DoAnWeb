namespace DoAnWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_User : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoaiSanPham",
                c => new
                    {
                        MaLoaiSanPham = c.String(nullable: false, maxLength: 10),
                        TenLoaiSanPham = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaLoaiSanPham);
            
            CreateTable(
                "dbo.NhaSanXuat",
                c => new
                    {
                        MaNhaSanXuat = c.String(nullable: false, maxLength: 10),
                        TenNhaSanXuat = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNhaSanXuat);
            
            CreateTable(
                "dbo.SanPham",
                c => new
                    {
                        MaSanPham = c.Int(nullable: false, identity: true),
                        MaLoaiSanPham = c.String(maxLength: 10),
                        MaNhaSanXuat = c.String(maxLength: 10),
                        TenSanPham = c.String(),
                        CauHinh = c.String(unicode: false, storeType: "text"),
                        HinhChinh = c.String(maxLength: 50),
                        Hinh1 = c.String(maxLength: 50),
                        Hinh2 = c.String(maxLength: 50),
                        Hinh3 = c.String(maxLength: 50),
                        Hinh4 = c.String(maxLength: 50),
                        Gia = c.Int(),
                        SoLuongBan = c.Int(),
                        LuotView = c.Int(),
                        TinhTrang = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.MaSanPham);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        idUser = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.idUser);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
            DropTable("dbo.SanPham");
            DropTable("dbo.NhaSanXuat");
            DropTable("dbo.LoaiSanPham");
        }
    }
}
