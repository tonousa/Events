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

            routes.MapPageRoute("d4", "store/default", "~/Store/Cart.aspx");
            routes.MapPageRoute("dall", "{app}/default", "~/Default.aspx",
                false, null,
                new RouteValueDictionary { { "app", "accounts|billing|payments" } });
            //routes.MapPageRoute("d2", "accounts/default", "~/Default.aspx");
            //routes.MapPageRoute("d3", "payments/default", "~/Default.aspx");

            RouteValueDictionary constraints = new RouteValueDictionary
            {
                {"first", "[0-9]*" }, {"second", "[0-9]*" }, {"operation", "plus|minus" }
            };

            routes.MapPageRoute("calc", "calc/{first}/{operation}/{second}",
                "~/Calc.aspx", false, null, constraints);

            routes.MapPageRoute("calc2", "calc/{first}/{second}/{operation}",
                "~/Calc.aspx", false,
                new RouteValueDictionary { { "operation", "plus" }, { "second", 30 } },
                constraints);

            routes.MapPageRoute("calc3", "calc/{operation}/{*numbers}", "~/calc.aspx");
        }
    }
}