namespace Suanha3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitFullDatabase : DbMigration
    {
        public override void Up()
        {
            // Tạo bảng AdminUsers
            CreateTable(
                "dbo.AdminUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);

            // Tạo bảng Services
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                        ImageUrl = c.String(maxLength: 500),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Services");
            DropTable("dbo.AdminUsers");
        }
    }
}
