namespace PropMan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class name_family : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AddColumn("dbo.AspNetUsers", "Family", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Family");
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
