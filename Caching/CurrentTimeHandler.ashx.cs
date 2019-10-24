using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Caching
{
    /// <summary>
    /// Summary description for CurrentTimeHandler
    /// </summary>
    public class CurrentTimeHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(string.Format("String generated at: {0}",
                DateTime.Now.ToLongTimeString()));
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