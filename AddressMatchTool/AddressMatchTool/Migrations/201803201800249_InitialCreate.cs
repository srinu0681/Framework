namespace AddressMatchTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AddressNumber = c.Int(nullable: false),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        ZipCode = c.String(),
                        Address_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Address", t => t.Address_ID)
                .Index(t => t.Address_ID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Address", t => t.Address_ID)
                .Index(t => t.Address_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customer", "Address_ID", "dbo.Address");
            DropForeignKey("dbo.Address", "Address_ID", "dbo.Address");
            DropIndex("dbo.Customer", new[] { "Address_ID" });
            DropIndex("dbo.Address", new[] { "Address_ID" });
            DropTable("dbo.Customer");
            DropTable("dbo.Address");
        }
    }
}
