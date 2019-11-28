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
            routes.RouteExistingFiles = true;

            routes.StopASPXRequests();

            //routes.Add("stop", new Route("methodtest", new StopRoutingHandler()));
            //routes.Ignore("methodtest");

            //routes.MapPageRoute("oldToNew", "Loop.aspx", "~/Default.aspx",
            //    false, null,
            //    new RouteValueDictionary
            //    {
            //        {"httpmethod", new HttpMethodConstraint("GET") }
            //    });

            //routes.MapPageRoute("store", "store/{target}", "~/Default.aspx");

            //Route wr = new Route("store/{target}",
            //    new PageRouteHandler("~/Default.aspx"));
            //wr.RouteExistingFiles = false;
            //routes.Add("store", wr);

            routes.MapPageRoute("default", "", "~/Default.aspx");


            routes.Add("flex1", new Route("generichandler",
                new FlexibleRouteHandler { HandlerType = "Routing.GenHandler" }));

            routes.Add("flex2", new Route("customhandlerfactory",
                new FlexibleRouteHandler
                {
                    HandlerType = "Routing.CustomHandlerFactory"
                }));

            routes.Add("flex3", new Route("customhandler",
                new FlexibleRouteHandler { HandlerType = "Routing.CustomHandler" }));


            routes.Add("browser", new BrowserRoute("browser",
                new Dictionary<Browser, string>
                {
                    { Browser.IE10, "~/Calc.aspx"},
                    { Browser.CHROME, "~/Loop.aspx" },
                    { Browser.OTHER, "~/Default.aspx" }
                }));

            routes.Add("apress", new Route("apress", null, null,
                new RouteValueDictionary { { "target", "http://apress.com" } },
                new RedirectionRouteHandler()));

            routes.MapPageRoute("postTest", "methodtest", "~/PostTest.aspx",
                false, null,
                new RouteValueDictionary {
                    { "httpMethod", new HttpMethodConstraint("POST") },
                    { "city", new FormDataConstraint("London") }
                });

            //routes.Add("stop", new Route("methodtest", null,
            //    new RouteValueDictionary
            //    {
            //        {"httpMethod", new HttpMethodConstraint("POST") }
            //    }, new StopRoutingHandler()));

            routes.Ignore("methodtest",
                new { httpMethod = new HttpMethodConstraint("POST") });

            routes.MapPageRoute("getTest", "methodtest", "~/GetTest.aspx",
                false, null, null);

            //routes.MapPageRoute("cart1", "cart", "~/Store/Cart.aspx");
            //routes.MapPageRoute("cart2", "apps/shopping/finish", "~/Store/Cart.aspx");

            //routes.MapPageRoute("d4", "store/default", "~/Store/Cart.aspx");
            //routes.MapPageRoute("dall", "{app}/default", "~/Default.aspx",
            //    false, null,
            //    new RouteValueDictionary { { "app", "accounts|billing|payments" } });
            //routes.MapPageRoute("d2", "accounts/default", "~/Default.aspx");
            //routes.MapPageRoute("d3", "payments/default", "~/Default.aspx");

            //RouteValueDictionary constraints = new RouteValueDictionary
            //{
            //    {"first", "[0-9]*" }, {"second", "[0-9]*" }, {"operation", "plus|minus" }
            //};

            //routes.MapPageRoute("calc", "calc/{first}/{operation}/{second}",
            //    "~/Calc.aspx", false, null, constraints);

            //routes.MapPageRoute("calc2", "calc/{first}/{second}/{operation}",
            //    "~/Calc.aspx", false,
            //    new RouteValueDictionary { { "operation", "plus" }, { "second", 30 } },
            //    constraints);

            //routes.MapPageRoute("calc3", "calc/{operation}/{*numbers}", "~/calc.aspx");

            //routes.MapPageRoute("loop", "{count}", "~/loop.aspx", false,
            //    new RouteValueDictionary { { "count", "3" } },
            //    new RouteValueDictionary { { "count", "[0-9]*" } });

            //routes.MapPageRoute("out", "out", "~/Out.aspx");
        }
    }
}