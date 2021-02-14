namespace ApplicationBDO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZMianaModeluLog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Log", "SizeFile", c => c.String());
            AddColumn("dbo.Log", "NoTracing", c => c.Boolean(nullable: false));
            AddColumn("dbo.Log", "BulkLoading", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Log", "BulkLoading");
            DropColumn("dbo.Log", "NoTracing");
            DropColumn("dbo.Log", "SizeFile");
        }
    }
}
