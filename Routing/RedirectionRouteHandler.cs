using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Routing
{
    public class RedirectionRouteHandler : IRouteHandler
    {
       public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new RedirectionHandler
            {
                TargetUrl = requestContext.RouteData.DataTokens["target"].ToString()
            };
        }
    }

    public class RedirectionHandler : IHttpHandler
    {
        public string TargetUrl { get; set; }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Redirect(TargetUrl);
        }

        public bool IsReusable { get { return false; } }
    }
}