namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class publisher_contact_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Publisher.Publisher",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Publisher.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Location = c.String(),
                        Phone = c.String(),
                        CellPhone = c.String(),
                        ManagerName = c.String(),
                        Email = c.String(),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Publisher.Publisher", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("Books.Book", "PublisherId", c => c.Int(nullable: false));
            CreateIndex("Books.Book", "PublisherId");
            AddForeignKey("Books.Book", "PublisherId", "Publisher.Publisher", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Publisher.Contact", "Id", "Publisher.Publisher");
            DropForeignKey("Books.Book", "PublisherId", "Publisher.Publisher");
            DropIndex("Publisher.Contact", new[] { "Id" });
            DropIndex("Books.Book", new[] { "PublisherId" });
            DropColumn("Books.Book", "PublisherId");
            DropTable("Publisher.Contact");
            DropTable("Publisher.Publisher");
        }
    }
}
