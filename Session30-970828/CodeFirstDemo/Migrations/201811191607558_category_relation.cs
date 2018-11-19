namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class category_relation : DbMigration
    {
        public override void Up()
        {
            AddColumn("Books.Book", "CategoryId", c => c.Int());
            CreateIndex("Books.Book", "CategoryId");
            AddForeignKey("Books.Book", "CategoryId", "Books.Category", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Books.Book", "CategoryId", "Books.Category");
            DropIndex("Books.Book", new[] { "CategoryId" });
            DropColumn("Books.Book", "CategoryId");
        }
    }
}
