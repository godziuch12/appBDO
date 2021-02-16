namespace ApplicationBDO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zmiana : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Company");
            AlterColumn("dbo.Company", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Company", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Company");
            AlterColumn("dbo.Company", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Company", "Id");
        }
    }
}
