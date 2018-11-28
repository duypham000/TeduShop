namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntitalDB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.VisitorStatitics", newName: "VisitorStatistics");
            RenameColumn(table: "dbo.IdentityUserClaims", name: "ApplicationUserID", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.IdentityUserLogins", name: "ApplicationUserID", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.IdentityUserRoles", name: "ApplicationUserID", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.IdentityUserRoles", name: "IdentityRoleID", newName: "IdentityRole_Id");
            RenameIndex(table: "dbo.IdentityUserRoles", name: "IX_IdentityRoleID", newName: "IX_IdentityRole_Id");
            RenameIndex(table: "dbo.IdentityUserRoles", name: "IX_ApplicationUserID", newName: "IX_ApplicationUser_Id");
            RenameIndex(table: "dbo.IdentityUserClaims", name: "IX_ApplicationUserID", newName: "IX_ApplicationUser_Id");
            RenameIndex(table: "dbo.IdentityUserLogins", name: "IX_ApplicationUserID", newName: "IX_ApplicationUser_Id");
            DropPrimaryKey("dbo.Slides");
            AddColumn("dbo.ApplicationUsers", "PhoneNumberConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.OrderDetails", "Quantitty", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "CustomerMobile", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Posts", "Description", c => c.String(maxLength: 500));
            AddColumn("dbo.Products", "MoreImages", c => c.String(storeType: "xml"));
            AddColumn("dbo.SupportOnlines", "Department", c => c.String(maxLength: 50));
            AlterColumn("dbo.ApplicationUsers", "EmailConfirmed", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ApplicationUsers", "LockoutEndDateUtc", c => c.DateTime());
            AlterColumn("dbo.Menus", "DisplayOrder", c => c.Int());
            AlterColumn("dbo.Orders", "CreatedBy", c => c.String());
            AlterColumn("dbo.Pages", "Alias", c => c.String(nullable: false, maxLength: 256, unicode: false));
            AlterColumn("dbo.PostCategories", "Alias", c => c.String(nullable: false, maxLength: 256, unicode: false));
            AlterColumn("dbo.PostCategories", "ParentID", c => c.Int());
            AlterColumn("dbo.PostCategories", "DisplayOrder", c => c.Int());
            AlterColumn("dbo.PostCategories", "HomeFlag", c => c.Boolean());
            AlterColumn("dbo.Posts", "HomeFlag", c => c.Boolean());
            AlterColumn("dbo.Posts", "HotFlag", c => c.Boolean());
            AlterColumn("dbo.Posts", "ViewCount", c => c.Int());
            AlterColumn("dbo.ProductCategories", "ParentID", c => c.Int());
            AlterColumn("dbo.ProductCategories", "DisplayOrder", c => c.Int());
            AlterColumn("dbo.ProductCategories", "HomeFlag", c => c.Boolean());
            AlterColumn("dbo.Products", "PromotionPrice", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Products", "Warranty", c => c.Int());
            AlterColumn("dbo.Products", "HomeFlag", c => c.Boolean());
            AlterColumn("dbo.Products", "HotFlag", c => c.Boolean());
            AlterColumn("dbo.Products", "ViewCount", c => c.Int());
            AlterColumn("dbo.Slides", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Slides", "DisplayOrder", c => c.Int());
            AlterColumn("dbo.SupportOnlines", "DisplayOrder", c => c.Int());
            AlterColumn("dbo.SystemConfigs", "Code", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.SystemConfigs", "ValueString", c => c.String(maxLength: 50));
            AlterColumn("dbo.SystemConfigs", "ValueInt", c => c.Int());
            AddPrimaryKey("dbo.Slides", "ID");
            CreateIndex("dbo.OrderDetails", "OrderID");
            CreateIndex("dbo.OrderDetails", "ProductID");
            AddForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders", "ID", cascadeDelete: true);
            AddForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products", "ID", cascadeDelete: true);
            DropColumn("dbo.ApplicationUsers", "PhoneNumberCofirmed");
            DropColumn("dbo.OrderDetails", "Quantity");
            DropColumn("dbo.Orders", "CustomerMobie");
            DropColumn("dbo.Orders", "UpdatedDate");
            DropColumn("dbo.Orders", "UpdatedBy");
            DropColumn("dbo.Orders", "MetaKeyword");
            DropColumn("dbo.Orders", "MetaDescription");
            DropColumn("dbo.Products", "MoreImage");
            DropColumn("dbo.SupportOnlines", "Depatment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SupportOnlines", "Depatment", c => c.String(maxLength: 50));
            AddColumn("dbo.Products", "MoreImage", c => c.String());
            AddColumn("dbo.Orders", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Orders", "MetaKeyword", c => c.String(maxLength: 256));
            AddColumn("dbo.Orders", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Orders", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Orders", "CustomerMobie", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.OrderDetails", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.ApplicationUsers", "PhoneNumberCofirmed", c => c.String(nullable: false));
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropPrimaryKey("dbo.Slides");
            AlterColumn("dbo.SystemConfigs", "ValueInt", c => c.Int(nullable: false));
            AlterColumn("dbo.SystemConfigs", "ValueString", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.SystemConfigs", "Code", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.SupportOnlines", "DisplayOrder", c => c.Int(nullable: false));
            AlterColumn("dbo.Slides", "DisplayOrder", c => c.Int(nullable: false));
            AlterColumn("dbo.Slides", "ID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Products", "ViewCount", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "HotFlag", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Products", "HomeFlag", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Products", "Warranty", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "PromotionPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProductCategories", "HomeFlag", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ProductCategories", "DisplayOrder", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductCategories", "ParentID", c => c.Int(nullable: false));
            AlterColumn("dbo.Posts", "ViewCount", c => c.Int(nullable: false));
            AlterColumn("dbo.Posts", "HotFlag", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Posts", "HomeFlag", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PostCategories", "HomeFlag", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PostCategories", "DisplayOrder", c => c.Int(nullable: false));
            AlterColumn("dbo.PostCategories", "ParentID", c => c.Int(nullable: false));
            AlterColumn("dbo.PostCategories", "Alias", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Pages", "Alias", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Orders", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Menus", "DisplayOrder", c => c.Int(nullable: false));
            AlterColumn("dbo.ApplicationUsers", "LockoutEndDateUtc", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ApplicationUsers", "EmailConfirmed", c => c.String(nullable: false));
            DropColumn("dbo.SupportOnlines", "Department");
            DropColumn("dbo.Products", "MoreImages");
            DropColumn("dbo.Posts", "Description");
            DropColumn("dbo.Orders", "CustomerMobile");
            DropColumn("dbo.OrderDetails", "Quantitty");
            DropColumn("dbo.ApplicationUsers", "PhoneNumberConfirmed");
            AddPrimaryKey("dbo.Slides", "ID");
            RenameIndex(table: "dbo.IdentityUserLogins", name: "IX_ApplicationUser_Id", newName: "IX_ApplicationUserID");
            RenameIndex(table: "dbo.IdentityUserClaims", name: "IX_ApplicationUser_Id", newName: "IX_ApplicationUserID");
            RenameIndex(table: "dbo.IdentityUserRoles", name: "IX_ApplicationUser_Id", newName: "IX_ApplicationUserID");
            RenameIndex(table: "dbo.IdentityUserRoles", name: "IX_IdentityRole_Id", newName: "IX_IdentityRoleID");
            RenameColumn(table: "dbo.IdentityUserRoles", name: "IdentityRole_Id", newName: "IdentityRoleID");
            RenameColumn(table: "dbo.IdentityUserRoles", name: "ApplicationUser_Id", newName: "ApplicationUserID");
            RenameColumn(table: "dbo.IdentityUserLogins", name: "ApplicationUser_Id", newName: "ApplicationUserID");
            RenameColumn(table: "dbo.IdentityUserClaims", name: "ApplicationUser_Id", newName: "ApplicationUserID");
            RenameTable(name: "dbo.VisitorStatistics", newName: "VisitorStatitics");
        }
    }
}
