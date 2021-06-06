namespace Tranthilananh_05.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_LopHocs : DbMigration
    {
        public override void Up()
        {
           
            CreateTable(
                "dbo.LopHocs",
                c => new
                    {
                        Malop = c.Int(nullable: false, identity: true),
                        Tenlop = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Malop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LopHocs");
            
        }
    }
}
