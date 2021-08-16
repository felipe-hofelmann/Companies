namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipCompaniesContacts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Contact_Id", c => c.Int());
            CreateIndex("dbo.Companies", "Contact_Id");
            AddForeignKey("dbo.Companies", "Contact_Id", "dbo.Contacts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "Contact_Id", "dbo.Contacts");
            DropIndex("dbo.Companies", new[] { "Contact_Id" });
            DropColumn("dbo.Companies", "Contact_Id");
        }
    }
}
