namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipCompaniesJobs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Jobs_Id", c => c.Int());
            CreateIndex("dbo.Companies", "Jobs_Id");
            AddForeignKey("dbo.Companies", "Jobs_Id", "dbo.Jobs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "Jobs_Id", "dbo.Jobs");
            DropIndex("dbo.Companies", new[] { "Jobs_Id" });
            DropColumn("dbo.Companies", "Jobs_Id");
        }
    }
}
