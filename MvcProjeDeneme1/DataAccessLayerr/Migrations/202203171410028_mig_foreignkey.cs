namespace DataAccessLayerr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_foreignkey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Customers");
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        dateTime = c.String(),
                        lat = c.String(),
                        lng = c.String(),
                        CustomerUsername = c.Int(nullable: false),
                        customer_CustomerUsername = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customers", t => t.customer_CustomerUsername)
                .Index(t => t.customer_CustomerUsername);
            
            AlterColumn("dbo.Customers", "CustomerUsername", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Customers", "CustomerUsername");
            DropColumn("dbo.Customers", "CustomerID");
            DropColumn("dbo.Customers", "CustomerName");
            DropColumn("dbo.Customers", "CustomerSurname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerSurname", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "CustomerName", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "CustomerID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Cars", "customer_CustomerUsername", "dbo.Customers");
            DropIndex("dbo.Cars", new[] { "customer_CustomerUsername" });
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "CustomerUsername", c => c.String(maxLength: 50));
            DropTable("dbo.Cars");
            AddPrimaryKey("dbo.Customers", "CustomerID");
        }
    }
}
