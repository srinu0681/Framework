namespace AddressMatchTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AddressDTO", newName: "Address");
            RenameTable(name: "dbo.CustomerDTO", newName: "Customer");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Customer", newName: "CustomerDTO");
            RenameTable(name: "dbo.Address", newName: "AddressDTO");
        }
    }
}
