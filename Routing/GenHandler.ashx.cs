using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Routing
{
    /// <summary>
    /// Summary description for GenHandler
    /// </summary>
    public class GenHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World from Generic Handler");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}