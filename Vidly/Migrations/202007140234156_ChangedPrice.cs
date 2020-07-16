namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Price", c => c.Single(nullable: false));
            AddColumn("dbo.Transactions", "TotalPrice", c => c.Single(nullable: false));
            DropColumn("dbo.Transactions", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Price", c => c.Single(nullable: false));
            DropColumn("dbo.Transactions", "TotalPrice");
            DropColumn("dbo.Movies", "Price");
        }
    }
}
