namespace HotelManagmentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumOfReservedDays = c.Int(),
                        RoomId = c.Int(nullable: false),
                        Type = c.String(),
                        RoomPrice = c.Double(nullable: false),
                        LaundryPrice = c.Double(),
                        RentCarPrice = c.Double(),
                        TotalPrice = c.Double(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BillDate = c.DateTime(),
                        NoAdults = c.Int(),
                        Nochild = c.Int(),
                        CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomInfo = c.String(),
                        RoomStatus = c.String(),
                        Extra = c.String(),
                        Type = c.String(),
                        RoomPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CheckIns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CheckInDate = c.DateTime(),
                        NumOfReservedDays = c.Int(),
                        CustomerId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        NoAdults = c.Int(),
                        NoChildren = c.Int(),
                        PassportNo = c.Int(nullable: false),
                        Checkoutstatus = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.CheckOuts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CheckOutDate = c.DateTime(),
                        CheckInId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        NoAdults = c.Int(nullable: false),
                        NoChildren = c.Int(),
                        PassportNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CheckIns", t => t.CheckInId, cascadeDelete: false)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: false)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: false)
                .Index(t => t.CheckInId)
                .Index(t => t.RoomId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        PassportNo = c.Int(nullable: false),
                        Gender = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        BirthDate = c.DateTime(),
                        Checkstatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceID = c.Int(nullable: false),
                        Room_Id = c.Int(nullable: false),
                        ServicePrice = c.Double(nullable: false),
                        FirstDay = c.DateTime(),
                        LastDay = c.DateTime(),
                        Quantity = c.Int(),
                        OrderPrice = c.Double(nullable: false),
                        CarId = c.Int(),
                        Loundry_Id = c.Int(),
                        Laundry_Id = c.Int(),
                        RentCar_Id = c.Int(),
                        Room_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Laundries", t => t.Laundry_Id)
                .ForeignKey("dbo.RentCars", t => t.RentCar_Id)
                .ForeignKey("dbo.Rooms", t => t.Room_Id1)
                .Index(t => t.Laundry_Id)
                .Index(t => t.RentCar_Id)
                .Index(t => t.Room_Id1);
            
            CreateTable(
                "dbo.Laundries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceId = c.Int(nullable: false),
                        ServiceName = c.String(),
                        ServiceInfo = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RentCars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceID = c.Int(nullable: false),
                        CarBrand = c.String(),
                        CustomerId = c.Int(),
                        Price = c.Double(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        MemorizeQuestion = c.String(),
                        MemorizeAnswer = c.String(),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Orders", "Room_Id1", "dbo.Rooms");
            DropForeignKey("dbo.Orders", "RentCar_Id", "dbo.RentCars");
            DropForeignKey("dbo.Orders", "Laundry_Id", "dbo.Laundries");
            DropForeignKey("dbo.CheckIns", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.CheckOuts", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.CheckOuts", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CheckIns", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CheckOuts", "CheckInId", "dbo.CheckIns");
            DropForeignKey("dbo.Bills", "RoomId", "dbo.Rooms");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Orders", new[] { "Room_Id1" });
            DropIndex("dbo.Orders", new[] { "RentCar_Id" });
            DropIndex("dbo.Orders", new[] { "Laundry_Id" });
            DropIndex("dbo.CheckOuts", new[] { "CustomerId" });
            DropIndex("dbo.CheckOuts", new[] { "RoomId" });
            DropIndex("dbo.CheckOuts", new[] { "CheckInId" });
            DropIndex("dbo.CheckIns", new[] { "RoomId" });
            DropIndex("dbo.CheckIns", new[] { "CustomerId" });
            DropIndex("dbo.Bills", new[] { "RoomId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Users");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.RentCars");
            DropTable("dbo.Laundries");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.CheckOuts");
            DropTable("dbo.CheckIns");
            DropTable("dbo.Rooms");
            DropTable("dbo.Bills");
        }
    }
}
