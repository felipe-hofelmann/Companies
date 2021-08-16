namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipJobsSkills : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Skills", "Jobs_Id", c => c.Int());
            CreateIndex("dbo.Skills", "Jobs_Id");
            AddForeignKey("dbo.Skills", "Jobs_Id", "dbo.Jobs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skills", "Jobs_Id", "dbo.Jobs");
            DropIndex("dbo.Skills", new[] { "Jobs_Id" });
            DropColumn("dbo.Skills", "Jobs_Id");
        }
    }
}
