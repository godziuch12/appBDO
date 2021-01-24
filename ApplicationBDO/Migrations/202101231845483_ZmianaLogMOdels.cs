namespace ApplicationBDO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZmianaLogMOdels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Log", "OperationName", c => c.String());
            AddColumn("dbo.Log", "OperationTime", c => c.String());
            AddColumn("dbo.Log", "Database", c => c.String());
            AddColumn("dbo.Log", "OperationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Log", "NumberOfRecords", c => c.Int(nullable: false));
            AddColumn("dbo.Log", "NumberOfFieldsModel", c => c.Int(nullable: false));
            AddColumn("dbo.Log", "EntityFramework", c => c.Boolean(nullable: false));
            DropColumn("dbo.Log", "NazwaOperacji");
            DropColumn("dbo.Log", "CzasOperacji");
            DropColumn("dbo.Log", "BazaDanych");
            DropColumn("dbo.Log", "DataOperacji");
            DropColumn("dbo.Log", "LiczbaRekordow");
            DropColumn("dbo.Log", "CzyEntityFramework");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Log", "CzyEntityFramework", c => c.Boolean(nullable: false));
            AddColumn("dbo.Log", "LiczbaRekordow", c => c.Int(nullable: false));
            AddColumn("dbo.Log", "DataOperacji", c => c.DateTime(nullable: false));
            AddColumn("dbo.Log", "BazaDanych", c => c.String());
            AddColumn("dbo.Log", "CzasOperacji", c => c.String());
            AddColumn("dbo.Log", "NazwaOperacji", c => c.String());
            DropColumn("dbo.Log", "EntityFramework");
            DropColumn("dbo.Log", "NumberOfFieldsModel");
            DropColumn("dbo.Log", "NumberOfRecords");
            DropColumn("dbo.Log", "OperationDate");
            DropColumn("dbo.Log", "Database");
            DropColumn("dbo.Log", "OperationTime");
            DropColumn("dbo.Log", "OperationName");
        }
    }
}
