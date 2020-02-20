namespace EntityFramework3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Customer_Cid", c => c.Int());
            CreateIndex("dbo.Products", "Customer_Cid");
            AddForeignKey("dbo.Products", "Customer_Cid", "dbo.Customers", "Cid");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Customer_Cid", "dbo.Customers");
            DropIndex("dbo.Products", new[] { "Customer_Cid" });
            DropColumn("dbo.Products", "Customer_Cid");
        }
    }
}
