using System.Web;
using System.Web.Mvc;

namespace InventorySystem
{
    /// <summary>
    /// Help to filter data
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Register filter into the system
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
