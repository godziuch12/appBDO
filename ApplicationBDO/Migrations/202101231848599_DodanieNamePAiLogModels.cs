namespace ApplicationBDO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodanieNamePAiLogModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Log", "NameAPI", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Log", "NameAPI");
        }
    }
}
