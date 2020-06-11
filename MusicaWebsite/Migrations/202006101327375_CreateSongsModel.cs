namespace MusicaWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSongsModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                        AuthorPicture = c.String(),
                        AuthorBiography = c.String(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        SongId = c.Int(nullable: false, identity: true),
                        SongName = c.String(),
                        Duration = c.String(),
                        Lyric = c.String(),
                        SongPath = c.String(),
                        TimeListen = c.Int(nullable: false),
                        Picture = c.String(),
                        DownloadLink = c.String(),
                        DateCreate = c.DateTime(nullable: false),
                        GenreId = c.Int(nullable: false),
                        SingerId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SongId)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .ForeignKey("dbo.Singers", t => t.SingerId, cascadeDelete: true)
                .Index(t => t.GenreId)
                .Index(t => t.SingerId)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Singers",
                c => new
                    {
                        SingerId = c.Int(nullable: false, identity: true),
                        SingerName = c.String(),
                        SingerPicture = c.String(),
                        SingerBiography = c.String(),
                    })
                .PrimaryKey(t => t.SingerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "SingerId", "dbo.Singers");
            DropForeignKey("dbo.Songs", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Songs", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Songs", new[] { "AuthorId" });
            DropIndex("dbo.Songs", new[] { "SingerId" });
            DropIndex("dbo.Songs", new[] { "GenreId" });
            DropTable("dbo.Singers");
            DropTable("dbo.Genres");
            DropTable("dbo.Songs");
            DropTable("dbo.Authors");
        }
    }
}
