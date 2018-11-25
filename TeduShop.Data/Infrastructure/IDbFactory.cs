namespace TeduShop.Data.Infrastructure
{
    public interface IDbFactory
    {
        TeduShopDbContext Init();
    }
}