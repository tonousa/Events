using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Routing
{
    public class FlexibleRouteHandler : IRouteHandler
    {
        public string HandlerType { get; set; }

        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            IHttpHandler handler = null;

            if (HandlerType != null)
            {
                object target = Activator.CreateInstance(Type.GetType(HandlerType));
                if (target is IHttpHandlerFactory 
                    && requestContext.HttpContext is HttpContextWrapper)
                {
                    handler = (target as IHttpHandlerFactory)
                }
            }
        }
    }
}