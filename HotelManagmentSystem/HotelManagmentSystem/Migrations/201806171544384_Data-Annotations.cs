namespace HotelManagmentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bills", "FirstName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Bills", "LastName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Customers", "LastName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Customers", "Email", c => c.String(maxLength: 150));
            AlterColumn("dbo.Customers", "Phone", c => c.String(maxLength: 20));
            AlterColumn("dbo.Customers", "Country", c => c.String(maxLength: 30));
            AlterColumn("dbo.Customers", "City", c => c.String(maxLength: 20));
            AlterColumn("dbo.Laundries", "ServiceName", c => c.String(maxLength: 100));
            AlterColumn("dbo.RentCars", "CarBrand", c => c.String(maxLength: 100));
            AlterColumn("dbo.Users", "Name", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.RentCars", "CarBrand", c => c.String());
            AlterColumn("dbo.Laundries", "ServiceName", c => c.String());
            AlterColumn("dbo.Customers", "City", c => c.String());
            AlterColumn("dbo.Customers", "Country", c => c.String());
            AlterColumn("dbo.Customers", "Phone", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            AlterColumn("dbo.Bills", "LastName", c => c.String());
            AlterColumn("dbo.Bills", "FirstName", c => c.String());
        }
    }
}
