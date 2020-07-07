namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Customers ALTER COLUMN Birthdate DateTime NULL;");
        }
        
        public override void Down()
        {
        }
    }
}
