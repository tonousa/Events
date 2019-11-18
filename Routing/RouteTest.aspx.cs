using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Routing
{
    public partial class RouteTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<RouteMatchInfo> GetRouteMatches()
        {
            HttpContextBase contextBase
                = new ContextMapper((string)Context.Items["routePath"], Request);

            foreach (RouteBase route in RouteTable.Routes)
            {
                if (route != null)
                {
                    RouteData rData = route.GetRouteData(contextBase);
                    if (rData != null)
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (string key in rData.Values.Keys)
                        {
                            sb.AppendFormat("{0} = {1},", key, rData.Values[key]);
                        }
                        yield return new RouteMatchInfo
                        {
                            matches = true,
                            path = route is Route ? ((Route)route).Url
                                : route.GetType().ToString(),
                            values = sb.ToString()
                        };
                    }
                    else
                    {
                        yield return new RouteMatchInfo
                        {
                            matches = false,
                            path = route is Route ? ((Route)route).Url
                                : route.GetType().ToString(),
                            values = "-"
                        };
                    }
                }
            }
        }
    }

    public class RouteMatchInfo
    {
        public bool matches { get; set; }
        public string path { get; set; }
        public string values { get; set; }
    }
}