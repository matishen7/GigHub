namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFollowing1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Followings", name: "Followee_Id", newName: "FolloweeId");
            RenameIndex(table: "dbo.Followings", name: "IX_Followee_Id", newName: "IX_FolloweeId");
            DropPrimaryKey("dbo.Followings");
            AddPrimaryKey("dbo.Followings", new[] { "FollowerId", "FolloweeId" });
            DropColumn("dbo.Followings", "FolloweeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Followings", "FolloweeName", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Followings");
            AddPrimaryKey("dbo.Followings", new[] { "FollowerId", "FolloweeName" });
            RenameIndex(table: "dbo.Followings", name: "IX_FolloweeId", newName: "IX_Followee_Id");
            RenameColumn(table: "dbo.Followings", name: "FolloweeId", newName: "Followee_Id");
        }
    }
}
