﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handlers
{
    public class InstanceControlFactory : IHttpHandlerFactory
    {
        private int factoryCounter = 0;

        public IHttpHandler GetHandler(HttpContext context, string requestType,
            string url, string pathTranslated)
        {
            return new InstanceControlHandler(++factoryCounter);
        }

        public void ReleaseHandler(IHttpHandler handler)
        {

        }
    }

    internal class InstanceControlHandler : IHttpHandler
    {
        private int handlerCounter;

        public InstanceControlHandler(int count)
        {
            handlerCounter = count;
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(string.Format("the counter value is: {0}",
                handlerCounter));
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}