namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5a687e04-db5a-422d-afa3-54d8a35c165f', N'guest@vidly.com', 0, N'ANtLrDxbFvNeLWBFnSoUSXZXeCdcbu4py+O9wTJi+3GlFqmq4WY7E/7I/xy9OorhRQ==', N'd13c900b-aa83-414c-8398-8849fe9a9b45', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'be352083-d635-4f24-a24d-12a1b66f83a3', N'adminadmin@admin.com', 0, N'AMgEJCr7213vrjDVBkVWW2MmVOH1d8qYBxtjz6SWLh+j1KGlunsF4ey9ajDhrBTlSw==', N'b8990b75-c690-40e9-bde4-01a8bb2e6f23', NULL, 0, 0, NULL, 1, 0, N'adminadmin@admin.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ff36685f-941f-4ae1-bff6-e7dd4d07e449', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'be352083-d635-4f24-a24d-12a1b66f83a3', N'ff36685f-941f-4ae1-bff6-e7dd4d07e449')

");
        }
        
        public override void Down()
        {
        }
    }
}
