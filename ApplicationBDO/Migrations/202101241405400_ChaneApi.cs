namespace ApplicationBDO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChaneApi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Log", "NameAPI", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Log", "NameAPI", c => c.Boolean(nullable: false));
        }
    }
}
