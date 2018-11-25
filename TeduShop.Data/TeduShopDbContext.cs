using System.Data.Entity;
using TeduShop.Model.Models;

namespace TeduShop.Data
{
    public class TeduShopDbContext : DbContext
    {
        public TeduShopDbContext() : base("TeduShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<IdentityRole> IdentityRoles { get; set; }
        public DbSet<IdentityUserClaim> IdentityUserClaims { get; set; }
        public DbSet<IdentityUserLogin> IdentityUserLogins { get; set; }
        public DbSet<IdentityUserRole> IdentityUserRoles { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatitic> VisitorStatitics { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
        }
    }
}