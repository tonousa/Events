using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handlers
{
    public class SelectionControlFactory : IHttpHandlerFactory
    {
        public IHttpHandler GetHandler(HttpContext context, string requestType, 
            string url, string pathTranslated)
        {
            if (url.ToLower().StartsWith("/time"))
            {
                return new CurrentTimeHandler();
            }
            else
            {
                return new CurrentDayHandler();
            }
        }

        public void ReleaseHandler(IHttpHandler handler)
        {
            //throw new NotImplementedException();
        }

        private class CurrentDayHandler : IHttpHandler
        {
            public void ProcessRequest(HttpContext context)
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write(string.Format("Today is: {0}", 
                    DateTime.Now.DayOfWeek.ToString()));
            }

            public bool IsReusable
            {
                get { return false; }
            }
        }

        private class CurrentTimeHandler : IHttpHandler
        {
            public bool IsReusable
            {
                get
                {
                    return false;
                }
            }

            public void ProcessRequest(HttpContext context)
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write(string.Format("The time is: {0}", 
                    DateTime.Now.ToShortDateString()));
            }
        }
    }
}