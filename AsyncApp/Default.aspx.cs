using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AsyncApp
{
    public partial class Default : System.Web.UI.Page
    {
        private WebSiteResult result;

        protected void Page_Load(object sender, EventArgs e)
        {
            string targetUrl = "https://www.ebay.com";
            WebClient client = new WebClient();
            result = new WebSiteResult { Url = targetUrl };
            Stopwatch sw = Stopwatch.StartNew();
            string webContent = client.DownloadString(targetUrl);
            result.Length = webContent.Length;
            result.Blocked = sw.ElapsedMilliseconds;
            result.Total
                = (long)DateTime.Now.Subtract(Context.Timestamp).TotalMilliseconds;
        }

        public WebSiteResult GetResult()
        {
            return result;
        }

        public class WebSiteResult
        {
            public string Url { get; set; }
            public long Length { get; set; }
            public long Blocked { get; set; }
            public long Total { get; set; }
        }
    }
}