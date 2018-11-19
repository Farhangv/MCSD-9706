namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class category_added : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Books", newName: "Book");
            MoveTable(name: "dbo.Book", newSchema: "Books");
            CreateTable(
                "Books.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("Books.Book", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("Books.Book", "Publisher", c => c.String(maxLength: 100));
            AlterColumn("Books.Book", "ISBN", c => c.String(nullable: false, maxLength: 13));
            AlterColumn("Books.Book", "Price", c => c.Double());
            AlterColumn("Books.Book", "PriceUnit", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("Books.Book", "PriceUnit", c => c.Int(nullable: false));
            AlterColumn("Books.Book", "Price", c => c.Double(nullable: false));
            AlterColumn("Books.Book", "ISBN", c => c.String());
            AlterColumn("Books.Book", "Publisher", c => c.String());
            AlterColumn("Books.Book", "Title", c => c.String());
            DropTable("Books.Category");
            MoveTable(name: "Books.Book", newSchema: "dbo");
            RenameTable(name: "dbo.Book", newName: "Books");
        }
    }
}
