namespace Suanha3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddServiceTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Title", c => c.String());
            AlterColumn("dbo.AdminUsers", "UserName", c => c.String());
            AlterColumn("dbo.AdminUsers", "Username", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdminUsers", "Username", c => c.String());
            AlterColumn("dbo.AdminUsers", "UserName", c => c.String(nullable: false));
            DropColumn("dbo.Services", "Title");
        }
    }
}
