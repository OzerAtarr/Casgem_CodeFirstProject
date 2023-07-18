﻿namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_footer_all : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Destination = c.String(),
                        Duration = c.String(),
                        Mail = c.String(),
                        BookingDate = c.DateTime(nullable: false),
                        BookingStatus = c.String(),
                    })
                .PrimaryKey(t => t.BookingID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Mail = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.ContactUs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationID = c.Int(nullable: false, identity: true),
                        DestinationName = c.String(),
                        DayNight = c.String(),
                        Capacity = c.Byte(nullable: false),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DestinationID);
            
            CreateTable(
                "dbo.FooterSocialMedias",
                c => new
                    {
                        FooterSocialMediaID = c.Int(nullable: false, identity: true),
                        FooterSocialMediaName = c.String(),
                        FooterSocialMediaUrl = c.String(),
                        FooterSocialMediaIcon = c.String(),
                    })
                .PrimaryKey(t => t.FooterSocialMediaID);
            
            CreateTable(
                "dbo.Galeries",
                c => new
                    {
                        GaleryID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.GaleryID);
            
            CreateTable(
                "dbo.Guides",
                c => new
                    {
                        GuideID = c.Int(nullable: false, identity: true),
                        GuideName = c.String(),
                        GuideTitle = c.String(),
                        GuideImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.GuideID);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaID = c.Int(nullable: false, identity: true),
                        SocialMediaName = c.String(),
                        SocialMediaIcon = c.String(),
                        SocialMediaUrl = c.String(),
                        GuideID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SocialMediaID)
                .ForeignKey("dbo.Guides", t => t.GuideID, cascadeDelete: true)
                .Index(t => t.GuideID);
            
            CreateTable(
                "dbo.TravelTrips",
                c => new
                    {
                        TravelTripID = c.Int(nullable: false, identity: true),
                        TravelTripName = c.String(),
                    })
                .PrimaryKey(t => t.TravelTripID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SocialMedias", "GuideID", "dbo.Guides");
            DropIndex("dbo.SocialMedias", new[] { "GuideID" });
            DropTable("dbo.TravelTrips");
            DropTable("dbo.SocialMedias");
            DropTable("dbo.Guides");
            DropTable("dbo.Galeries");
            DropTable("dbo.FooterSocialMedias");
            DropTable("dbo.Destinations");
            DropTable("dbo.ContactUs");
            DropTable("dbo.Contacts");
            DropTable("dbo.Categories");
            DropTable("dbo.Bookings");
            DropTable("dbo.Admins");
        }
    }
}
