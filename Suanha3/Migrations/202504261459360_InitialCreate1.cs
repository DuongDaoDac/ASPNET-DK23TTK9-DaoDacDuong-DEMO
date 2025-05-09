namespace Suanha3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Contacts", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Message", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Message", c => c.String());
            AlterColumn("dbo.Contacts", "Phone", c => c.String());
            AlterColumn("dbo.Contacts", "Email", c => c.String());
            AlterColumn("dbo.Contacts", "Name", c => c.String());
            DropColumn("dbo.Contacts", "CreatedDate");
        }
    }
}
