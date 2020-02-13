namespace ApplicationBDO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodanietModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registrans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NIP = c.String(),
                        NumerRejestrowy = c.String(),
                        Adres = c.String(),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transmitting",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NIP = c.String(),
                        NumerRejestrowy = c.String(),
                        Adres = c.String(),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transport",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NIP = c.String(),
                        NumerRejestrowy = c.String(),
                        Adres = c.String(),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transport");
            DropTable("dbo.Transmitting");
            DropTable("dbo.Registrans");
        }
    }
}
