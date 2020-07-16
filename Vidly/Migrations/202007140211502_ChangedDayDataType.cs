namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDayDataType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Schedules", "Day", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Schedules", "Day", c => c.String());
        }
    }
}
