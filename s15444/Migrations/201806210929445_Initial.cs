namespace s15444.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Osobas",
                c => new
                    {
                        IdOsoba = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        IdType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOsoba)
                .ForeignKey("dbo.Types", t => t.IdType, cascadeDelete: true)
                .Index(t => t.IdType);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        IdType = c.Int(nullable: false, identity: true),
                        Rabat = c.String(nullable: false, maxLength: 4),
                    })
                .PrimaryKey(t => t.IdType);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Osobas", "IdType", "dbo.Types");
            DropIndex("dbo.Osobas", new[] { "IdType" });
            DropTable("dbo.Types");
            DropTable("dbo.Osobas");
        }
    }
}
