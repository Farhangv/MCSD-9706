namespace PropMan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullable_prices : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Property", "SaleUnitPrice", c => c.Int());
            AlterColumn("dbo.Property", "RentDiposite", c => c.Int());
            AlterColumn("dbo.Property", "RentMonthly", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Property", "RentMonthly", c => c.Int(nullable: false));
            AlterColumn("dbo.Property", "RentDiposite", c => c.Int(nullable: false));
            AlterColumn("dbo.Property", "SaleUnitPrice", c => c.Int(nullable: false));
        }
    }
}
