using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handlers
{
    public class RecyclingFactory : IHttpHandlerFactory
    {
        private int handler_count = 0;
        private int handler_limit = 100;
        private BlockingCollection<RecyclingHandler> pool = 
            new BlockingCollection<RecyclingHandler>();
        private int totalRequests;

        public IHttpHandler GetHandler(HttpContext context, string reqType,
            string url, string pathTranslated)
        {
            totalRequests++;
            RecyclingHandler handler;

            if (!pool.TryTake(out handler))
            {
                if (handler_count < handler_limit)
                {
                    handler_count++;
                    handler = new RecyclingHandler(this, handler_count);
                    pool.Add(handler);
                }
                else
                {
                    handler = pool.Take();
                }
            }
            handler.RequestCount++;
            return handler;
        }

        public void ReleaseHandler(IHttpHandler handler)
        {
            if (handler.IsReusable)
            {
                pool.Add((RecyclingHandler)handler);
            }
        }

        private class RecyclingHandler : IHttpHandler
        {
            private RecyclingFactory factory;
            private int handlerID;

            public RecyclingHandler(RecyclingFactory f, int id)
            {
                factory = f;
                handlerID = id;
            }

            public void ProcessRequest(HttpContext context)
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write(string.Format
                    ("Total requests: {0}, HandlerID: {1}, HandlerRequests: {2}",
                    factory.totalRequests, handlerID, RequestCount));
            }

            public bool IsReusable
            {
                get { return RequestCount < 4; }
            }

            public int RequestCount { get; set; }
        }
    }
}