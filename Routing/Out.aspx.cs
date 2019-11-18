using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Routing;

namespace Routing
{
    public partial class Out : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string GenerateURL()
        {
            return GetRouteUrl("calc", new RouteValueDictionary
            {
                {"first", "10" }, {"operation" , "plus"}, { "second", "20"}

            });
        }
    }
}