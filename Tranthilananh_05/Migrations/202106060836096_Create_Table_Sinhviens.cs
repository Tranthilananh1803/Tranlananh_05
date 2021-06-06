namespace Tranthilananh_05.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Sinhviens : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sinhviens",
                c => new
                    {
                        Masinhvien = c.String(nullable: false, maxLength: 20),
                        Tensinhvien = c.String(maxLength: 50),
                        Malop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Masinhvien);
            
            AddColumn("dbo.LopHocs", "SinhVien_Masinhvien", c => c.String(maxLength: 20));
            CreateIndex("dbo.LopHocs", "SinhVien_Masinhvien");
            AddForeignKey("dbo.LopHocs", "SinhVien_Masinhvien", "dbo.Sinhviens", "Masinhvien");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LopHocs", "SinhVien_Masinhvien", "dbo.Sinhviens");
            DropIndex("dbo.LopHocs", new[] { "SinhVien_Masinhvien" });
            DropColumn("dbo.LopHocs", "SinhVien_Masinhvien");
            DropTable("dbo.Sinhviens");
        }
    }
}
