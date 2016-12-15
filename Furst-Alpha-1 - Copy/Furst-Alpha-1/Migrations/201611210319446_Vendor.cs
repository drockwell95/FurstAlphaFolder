namespace Furst_Alpha_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vendor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assets", "Vendor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Assets", "Vendor");
        }
    }
}
