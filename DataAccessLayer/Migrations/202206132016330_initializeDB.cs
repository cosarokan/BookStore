namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initializeDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        BirthDate = c.DateTime(),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookName = c.String(nullable: false, maxLength: 100),
                        ISBN = c.String(),
                        BookTypeId = c.Byte(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        YearOfPublication = c.Int(nullable: false),
                        Page = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.BookTypes", t => t.BookTypeId, cascadeDelete: true)
                .Index(t => t.BookTypeId)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.BookTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        TypeName = c.String(nullable: false, maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "BookTypeId", "dbo.BookTypes");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropIndex("dbo.Books", new[] { "BookTypeId" });
            DropTable("dbo.BookTypes");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
