namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Schedules", "MovieId");
            AddForeignKey("dbo.Schedules", "MovieId", "dbo.Movies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "MovieId", "dbo.Movies");
            DropIndex("dbo.Schedules", new[] { "MovieId" });
        }
    }
}
