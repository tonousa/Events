using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("default", "", "~/Default.aspx");
            routes.MapPageRoute("cart1", "cart", "~/Store/Cart.aspx");
            routes.MapPageRoute("cart2", "apps/shopping/finish", "~/Store/Cart.aspx");

            routes.MapPageRoute("dall", "{app}/default", "~/Default.aspx");
            //routes.MapPageRoute("d2", "accounts/default", "~/Default.aspx");
            //routes.MapPageRoute("d3", "payments/default", "~/Default.aspx");
            routes.MapPageRoute("d4", "store/default", "~/Store/Cart.aspx");

        }
    }
}