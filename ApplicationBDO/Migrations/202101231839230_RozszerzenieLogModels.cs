namespace ApplicationBDO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RozszerzenieLogModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Log", "LiczbaRekordow", c => c.Int(nullable: false));
            AddColumn("dbo.Log", "CzyEntityFramework", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Log", "CzyEntityFramework");
            DropColumn("dbo.Log", "LiczbaRekordow");
        }
    }
}
