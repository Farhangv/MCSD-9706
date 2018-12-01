namespace PropMan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class business_entities_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(maxLength: 50),
                        City = c.String(maxLength: 50),
                        District = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Property",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Area = c.Int(nullable: false),
                        BedRoomsCount = c.Int(nullable: false),
                        Position = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ValidUntilDate = c.DateTime(),
                        AdType = c.Int(nullable: false),
                        SaleUnitPrice = c.Int(nullable: false),
                        RentDiposite = c.Int(nullable: false),
                        RentMonthly = c.Int(nullable: false),
                        CreatedUserId = c.String(maxLength: 128),
                        LocationId = c.Int(nullable: false),
                        PropertyTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedUserId)
                .ForeignKey("dbo.Location", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.PropertyType", t => t.PropertyTypeId, cascadeDelete: true)
                .Index(t => t.CreatedUserId)
                .Index(t => t.LocationId)
                .Index(t => t.PropertyTypeId);
            
            CreateTable(
                "dbo.Media",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileContent = c.Binary(),
                        OriginalFileName = c.String(maxLength: 100),
                        ContentType = c.String(maxLength: 30),
                        FileSize = c.Int(nullable: false),
                        PropertyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Property", t => t.PropertyId, cascadeDelete: true)
                .Index(t => t.PropertyId);
            
            CreateTable(
                "dbo.PropertyType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "PhotoFilePath", c => c.String(maxLength: 150));
            AlterColumn("dbo.AspNetUsers", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.AspNetUsers", "Family", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Property", "PropertyTypeId", "dbo.PropertyType");
            DropForeignKey("dbo.Media", "PropertyId", "dbo.Property");
            DropForeignKey("dbo.Property", "LocationId", "dbo.Location");
            DropForeignKey("dbo.Property", "CreatedUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Media", new[] { "PropertyId" });
            DropIndex("dbo.Property", new[] { "PropertyTypeId" });
            DropIndex("dbo.Property", new[] { "LocationId" });
            DropIndex("dbo.Property", new[] { "CreatedUserId" });
            AlterColumn("dbo.AspNetUsers", "Family", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Name", c => c.String());
            DropColumn("dbo.AspNetUsers", "PhotoFilePath");
            DropTable("dbo.PropertyType");
            DropTable("dbo.Media");
            DropTable("dbo.Property");
            DropTable("dbo.Location");
        }
    }
}
