namespace Suanha3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNewsSchema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AdminUsers", "Username", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdminUsers", "Username", c => c.String());
            DropColumn("dbo.Services", "CreatedDate");
        }
    }
}
