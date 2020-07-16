namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newTables1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionDate = c.DateTime(),
                        TotalPrice = c.Single(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.TransactionDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        NewTransactionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.NewTransactions", t => t.NewTransactionId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.NewTransactionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionDetails", "NewTransactionId", "dbo.NewTransactions");
            DropForeignKey("dbo.TransactionDetails", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.NewTransactions", "CustomerId", "dbo.Customers");
            DropIndex("dbo.TransactionDetails", new[] { "NewTransactionId" });
            DropIndex("dbo.TransactionDetails", new[] { "MovieId" });
            DropIndex("dbo.NewTransactions", new[] { "CustomerId" });
            DropTable("dbo.TransactionDetails");
            DropTable("dbo.NewTransactions");
        }
    }
}
