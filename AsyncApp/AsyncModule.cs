using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace AsyncApp
{
    public class AsyncModule : IHttpModule
    {
        public void Init(HttpApplication app)
        {
            EventHandlerTaskAsyncHelper helper
                = new EventHandlerTaskAsyncHelper(async (src, args) =>
                {
                    if (app.Context.Request.Path == "/DisplayItemValue.aspx")
                    {
                        string content = await new
                            WebClient().DownloadStringTaskAsync("http://ebay.com");
                        ((HttpApplication)src).Context.Items["length"] = content.Length;
                    }
                });
            app.AddOnBeginRequestAsync(helper.BeginEventHandler, helper.EndEventHandler);
        }

        public void Dispose()
        {
            //
        }
    }
}