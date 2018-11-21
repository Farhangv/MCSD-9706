namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class publisher_removed : DbMigration
    {
        public override void Up()
        {
            DropColumn("Books.Book", "Publisher");
        }
        
        public override void Down()
        {
            AddColumn("Books.Book", "Publisher", c => c.String(maxLength: 100));
        }
    }
}
