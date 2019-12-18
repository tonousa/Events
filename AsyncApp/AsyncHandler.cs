using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace AsyncApp
{
    public class AsyncHandler : HttpTaskAsyncHandler
    {
        public override async Task ProcessRequestAsync(HttpContext context)
        {
            string webResponse
                = await new WebClient().DownloadStringTaskAsync("http://ebay.com");
            context.Response.Write(string.Format("Length of result: {0}",
                webResponse.Length));
        }
    }
}