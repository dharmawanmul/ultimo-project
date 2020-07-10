namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStoreManager : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'6dbe6991-e3c1-4068-8a05-12b604ef8f37', N'StoreManager@vidly.com', 0, N'AKc7zLGmiuEi6aQXv9sXUiHHWANgCicpgfgLQy4+/8lvWslBiUkrPX6SAMbXp0aswA==', N'96bd8326-586b-4759-8568-3eb3becfe7dd', NULL, 0, 0, NULL, 1, 0, N'StoreManager@vidly.com', N'456987123')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0d2007ee-cf28-4916-aace-9ffc7f53d6fe', N'StoreManager')            
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6dbe6991-e3c1-4068-8a05-12b604ef8f37', N'0d2007ee-cf28-4916-aace-9ffc7f53d6fe')
");
        }
        
        public override void Down()
        {
        }
    }
}
