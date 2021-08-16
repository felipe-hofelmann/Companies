namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipCompaniesProfiles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Profile_Id", c => c.Int());
            CreateIndex("dbo.Companies", "Profile_Id");
            AddForeignKey("dbo.Companies", "Profile_Id", "dbo.Profiles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "Profile_Id", "dbo.Profiles");
            DropIndex("dbo.Companies", new[] { "Profile_Id" });
            DropColumn("dbo.Companies", "Profile_Id");
        }
    }
}
