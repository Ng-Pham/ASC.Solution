using ASC.Web.Models;

namespace ASC.Web.Data
{
    public interface INavigationCacheOperations
    {
        Task<NavigationMenu> GetNavigationMenuAsync();
        Task CreateNavigationCacheAsync();
    }
}
