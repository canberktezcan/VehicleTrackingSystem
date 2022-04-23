namespace DataAccessLayerr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "dateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "dateTime", c => c.String());
        }
    }
}
