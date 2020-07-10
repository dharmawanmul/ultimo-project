namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPhoneNumber : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String(maxLength: 50));
            Sql(@"
            Update dbo.AspNetUsers SET PhoneNumber='123456789' WHERE UserName='guest@vidly.com'
            Update dbo.AspNetUsers SET PhoneNumber='123456789' WHERE UserName='StoreManager@vidly.com'
            Update dbo.AspNetUsers SET PhoneNumber='123456789' WHERE UserName='adminadmin@admin.com'
            Update dbo.AspNetUsers SET PhoneNumber='123456789' WHERE UserName='user1@vidly.com'
");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
