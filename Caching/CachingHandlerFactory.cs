using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Compilation;
using System.Web.UI;

namespace Caching
{
    public class CachingHandlerFactory : IHttpHandlerFactory
    {
        public IHttpHandler GetHandler(HttpContext context, string requestType,
            string url, string pathTranslated)
        {
            string response = GetFromCache(context, pathTranslated);
            if (response == null)
            {
                IHttpHandler handler = BuildManager.CreateInstanceFromVirtualPath(
                    context.Request.Path, typeof(IHttpHandler)) as IHttpHandler;

                StringWriter sr = new StringWriter();
                context.Server.Execute(new PageWrapper(handler), sr, true);
                response = sr.ToString();
                AddToCache(context, pathTranslated, response);
            }
            return new CachedResponseHandler(response);
        }

        private void AddToCache(HttpContext context, string pathTranslated, string response)
        {
            OutputCacheProvider oc =
                OutputCache.Providers[OutputCache.DefaultProviderName];
            if (oc != null)
            {
                oc.Add(pathTranslated, response, DateTime.Now.AddSeconds(600));
            }
            else
            {
                context.Cache.Add(pathTranslated, response, null, DateTime.Now.AddSeconds(600),
                    Cache.NoSlidingExpiration, CacheItemPriority.Low, null);
            }
        }

        public void ReleaseHandler(IHttpHandler handler)
        {

        }

        private string GetFromCache(HttpContext context, string path)
        {
            OutputCacheProvider oc =
                OutputCache.Providers[OutputCache.DefaultProviderName];
            if (oc != null)
            {
                return oc.Get(path) as string;
            }
            else
            {
                return context.Cache.Get(path) as string;
            }
        }

        private class CachedResponseHandler : IHttpHandler
        {
            private string cachedResponse;

            public CachedResponseHandler(string response)
            {
                cachedResponse = response;
            }

            public void ProcessRequest(HttpContext context)
            {
                context.Response.Write(cachedResponse);
            }
            
            public bool IsReusable
            {
                get { return false; }
            }
        }

        private class PageWrapper : Page
        {
            private IHttpHandler wrappedHandler;

            public PageWrapper(IHttpHandler handler)
            {
                wrappedHandler = handler;
            }

            public override void ProcessRequest(HttpContext context)
            {
                wrappedHandler.ProcessRequest(context);
            }
        }
    }
}