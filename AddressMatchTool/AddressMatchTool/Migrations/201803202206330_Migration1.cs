namespace AddressMatchTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Address", newName: "AddressDTO");
            RenameTable(name: "dbo.Customer", newName: "CustomerDTO");
            RenameColumn(table: "dbo.AddressDTO", name: "Address_ID", newName: "AddressDTO_ID");
            RenameIndex(table: "dbo.AddressDTO", name: "IX_Address_ID", newName: "IX_AddressDTO_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.AddressDTO", name: "IX_AddressDTO_ID", newName: "IX_Address_ID");
            RenameColumn(table: "dbo.AddressDTO", name: "AddressDTO_ID", newName: "Address_ID");
            RenameTable(name: "dbo.CustomerDTO", newName: "Customer");
            RenameTable(name: "dbo.AddressDTO", newName: "Address");
        }
    }
}
