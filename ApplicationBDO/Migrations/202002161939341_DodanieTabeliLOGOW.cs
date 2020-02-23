namespace ApplicationBDO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodanieTabeliLOGOW : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Log",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazwaOperacji = c.String(),
                        CzasOperacji = c.String(),
                        BazaDanych = c.String(),
                        DataOperacji = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Log");
        }
    }
}
