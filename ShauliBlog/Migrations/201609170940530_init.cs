namespace ShauliBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        PostID = c.Int(nullable: false),
                        commentdate = c.DateTime(nullable: false),
                        commentheadline = c.String(),
                        commentauthor = c.String(),
                        commentauthorurl = c.String(),
                        commentcontent = c.String(),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        headline = c.String(),
                        author = c.String(),
                        authorurl = c.String(),
                        postdate = c.DateTime(nullable: false),
                        postcontent = c.String(),
                        image = c.String(),
                        video = c.String(),
                    })
                .PrimaryKey(t => t.PostID);
            
            CreateTable(
                "dbo.FanClubModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Bday = c.DateTime(nullable: false),
                        gender = c.Int(nullable: false),
                        joinYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "PostID", "dbo.Posts");
            DropIndex("dbo.Comments", new[] { "PostID" });
            DropTable("dbo.FanClubModels");
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
        }
    }
}
