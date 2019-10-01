using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RequestControl
{
    /// <summary>
    /// Summary description for CurrentTimeHandler
    /// </summary>
    public class CurrentTimeHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(string.Format("Current time: {0}", 
                DateTime.Now.ToShortTimeString()));
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