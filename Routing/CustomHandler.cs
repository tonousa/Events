using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Routing
{
    public class CustomHandlerFactory : IHttpHandlerFactory
    {
        public IHttpHandler GetHandler(HttpContext context, string requestType,
            string url, string pathTranslated)
        {
            return new CustomHandler() { FactoryCreated = true };
        }

        public void ReleaseHandler(IHttpHandler handler)
        {
            //
        }
    }

    public class CustomHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("This is the custom hanlder");
            if (FactoryCreated)
            {
                context.Response.Write(" (Created via the Factory)");
            }
            else
            {
                context.Response.Write(" (Created directly)");
            }
        }

        public bool IsReusable
        {
            get { return false; }
        }

        public bool FactoryCreated { get; set; }
    }
}