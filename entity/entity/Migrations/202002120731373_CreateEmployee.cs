namespace entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Eid = c.Int(nullable: false, identity: true),
                        Ename = c.String(),
                        Designation = c.String(),
                        salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Eid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
