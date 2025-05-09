namespace Suanha3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateContactModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminUsers", "Role", c => c.String());
            AddColumn("dbo.AdminUsers", "Services", c => c.String());
            AddColumn("dbo.AdminUsers", "SubmittedDate", c => c.DateTime());
            AddColumn("dbo.Contacts", "FullName", c => c.String(nullable: false));
            AddColumn("dbo.Contacts", "Content", c => c.String());
            AddColumn("dbo.Contacts", "SubmittedDate", c => c.DateTime());
            AddColumn("dbo.Services", "ImageUrl", c => c.String());
            AddColumn("dbo.Services", "Category", c => c.String());
            AddColumn("dbo.Services", "Address", c => c.String());
            AddColumn("dbo.Services", "Phone", c => c.String());
            AddColumn("dbo.Services", "ServiceName", c => c.String());
            AddColumn("dbo.Services", "ServiceDescription", c => c.String());
            AddColumn("dbo.Services", "ServiceImageUrl", c => c.String());
            AddColumn("dbo.Services", "ServiceCategory", c => c.String());
            AddColumn("dbo.Services", "ServiceAddress", c => c.String());
            AddColumn("dbo.Services", "ServicePhone", c => c.String());
            AddColumn("dbo.Services", "ServiceEmail", c => c.String());
            AddColumn("dbo.Services", "type", c => c.String());
            AlterColumn("dbo.AdminUsers", "UserName", c => c.String());
            DropColumn("dbo.Contacts", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.AdminUsers", "UserName", c => c.String(nullable: false));
            DropColumn("dbo.Services", "type");
            DropColumn("dbo.Services", "ServiceEmail");
            DropColumn("dbo.Services", "ServicePhone");
            DropColumn("dbo.Services", "ServiceAddress");
            DropColumn("dbo.Services", "ServiceCategory");
            DropColumn("dbo.Services", "ServiceImageUrl");
            DropColumn("dbo.Services", "ServiceDescription");
            DropColumn("dbo.Services", "ServiceName");
            DropColumn("dbo.Services", "Phone");
            DropColumn("dbo.Services", "Address");
            DropColumn("dbo.Services", "Category");
            DropColumn("dbo.Services", "ImageUrl");
            DropColumn("dbo.Contacts", "SubmittedDate");
            DropColumn("dbo.Contacts", "Content");
            DropColumn("dbo.Contacts", "FullName");
            DropColumn("dbo.AdminUsers", "SubmittedDate");
            DropColumn("dbo.AdminUsers", "Services");
            DropColumn("dbo.AdminUsers", "Role");
        }
    }
}
