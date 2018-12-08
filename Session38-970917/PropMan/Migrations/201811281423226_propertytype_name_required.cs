namespace PropMan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class propertytype_name_required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PropertyType", "Name", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PropertyType", "Name", c => c.String(maxLength: 15));
        }
    }
}
