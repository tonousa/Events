﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Routing.Store
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string GetUrlFromRoute()
        {
            Route myRoute = Page.RouteData.Route as Route;
            if (myRoute != null)
            {
                return myRoute.Url;
            }
            else
            {
                return "Unknown RouteBase";
            }
        }
    }
}