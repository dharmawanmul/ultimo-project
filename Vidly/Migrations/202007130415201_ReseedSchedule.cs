namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReseedSchedule : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO Schedules (Day, MovieId) VALUES ('Monday', 1)
                INSERT INTO Schedules (Day, MovieId) VALUES ('Tuesday', 7)
                INSERT INTO Schedules (Day, MovieId) VALUES ('Wednesday', 9)
                INSERT INTO Schedules (Day, MovieId) VALUES ('Thursday', 9)
                INSERT INTO Schedules (Day, MovieId) VALUES ('Friday', 1)
                INSERT INTO Schedules (Day, MovieId) VALUES ('Saturday', 7)
                INSERT INTO Schedules (Day, MovieId) VALUES ('Sunday', 7)
            ");
        }
        
        public override void Down()
        {
        }
    }
}
