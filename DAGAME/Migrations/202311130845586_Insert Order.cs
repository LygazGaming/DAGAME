namespace DAGAME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "CustomerId", c => c.String());
            DropColumn("dbo.tb_Order", "Quantity");
            DropColumn("dbo.tb_Product", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Product", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.tb_Order", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.tb_Order", "CustomerId");
        }
    }
}
