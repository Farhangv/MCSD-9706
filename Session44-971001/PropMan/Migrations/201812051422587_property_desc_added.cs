namespace PropMan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class property_desc_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Property", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Property", "Description");
        }
    }
}
