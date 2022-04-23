namespace DataAccessLayerr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        dateTime = c.String(),
                        lat = c.String(),
                        lng = c.String(),
                        CustomerUsername = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customers", t => t.CustomerUsername)
                .Index(t => t.CustomerUsername);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerUsername = c.String(nullable: false, maxLength: 50),
                        CustomerPassword = c.String(maxLength: 50),
                        CustomerLoginTime = c.DateTime(nullable: false),
                        CustomerLogoutTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerUsername);
            
            CreateTable(
                "dbo.Gates",
                c => new
                    {
                        GateID = c.Int(nullable: false, identity: true),
                        GateLat = c.Double(nullable: false),
                        GateLng = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.GateID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CustomerUsername", "dbo.Customers");
            DropIndex("dbo.Cars", new[] { "CustomerUsername" });
            DropTable("dbo.Gates");
            DropTable("dbo.Customers");
            DropTable("dbo.Cars");
        }
    }
}
