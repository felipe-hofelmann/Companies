namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipCompaniesAddresses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Address_Id", c => c.Int());
            CreateIndex("dbo.Companies", "Address_Id");
            AddForeignKey("dbo.Companies", "Address_Id", "dbo.Addresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Companies", new[] { "Address_Id" });
            DropColumn("dbo.Companies", "Address_Id");
        }
    }
}
