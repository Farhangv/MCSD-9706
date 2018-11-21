namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class author : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Books.Author",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family = c.String(),
                        Nationality = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Books.Author_Book",
                c => new
                    {
                        Book_Id = c.Int(nullable: false),
                        Author_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_Id, t.Author_Id })
                .ForeignKey("Books.Book", t => t.Book_Id, cascadeDelete: true)
                .ForeignKey("Books.Author", t => t.Author_Id, cascadeDelete: true)
                .Index(t => t.Book_Id)
                .Index(t => t.Author_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Books.Author_Book", "Author_Id", "Books.Author");
            DropForeignKey("Books.Author_Book", "Book_Id", "Books.Book");
            DropIndex("Books.Author_Book", new[] { "Author_Id" });
            DropIndex("Books.Author_Book", new[] { "Book_Id" });
            DropTable("Books.Author_Book");
            DropTable("Books.Author");
        }
    }
}
