namespace ApplicationBDO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsiniecieDanych : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Registrans");
            DropTable("dbo.Transmitting");
            DropTable("dbo.Transport");
            DropTable("dbo.WasteCode");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.WasteCode",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WasteCodeId = c.Int(),
                        DateCreated = c.DateTime(),
                        Code = c.String(),
                        Description = c.String(),
                        IsDangerous = c.Boolean(),
                        Deleted = c.Boolean(),
                        Level = c.Int(),
                        ParentId = c.Int(),
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
            
        }
    }
}
