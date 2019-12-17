using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AsyncApp
{
    public class MultiWebSiteResult
    {
        public string Url { get; set; }
        public long Length { get; set; }
        public long StartTime { get; set; }
    }

    public partial class Multiples : System.Web.UI.Page
    {
        private ConcurrentQueue<MultiWebSiteResult> results;

        protected void Page_Load(object sender, EventArgs e)
        {
            string[] targetUrls = {
                "http://ebay.com", "https://www.aol.com", "http://ebay.com"
            };
            results = new ConcurrentQueue<MultiWebSiteResult>();

            RegisterAsyncTask(new PageAsyncTask(async () =>
            {
                List<Task> tasks = new List<Task>();
                foreach (string targetUrl in targetUrls)
                {
                    tasks.Add(Task.Factory.StartNew(() => {
                        MultiWebSiteResult result = new MultiWebSiteResult { Url = targetUrl };
                        result.StartTime =
                            (long)DateTime.Now.Subtract(Context.Timestamp).TotalMilliseconds;
                        Task<string> innerTask
                            = new WebClient().DownloadStringTaskAsync(targetUrl);
                        innerTask.Wait();
                        result.Length = innerTask.Result.Length;
                        results.Enqueue(result);
                    }));
                }
                await Task.WhenAll(tasks);
                rep.DataBind();
            }));

            //string[] targetUrls = {
            //    "http://ebay.com", "https://msn.com", "https://yahoo.com"
            //};
            //results = new ConcurrentQueue<MultiWebSiteResult>();

            //foreach (string targetUrl in targetUrls)
            //{
            //    MultiWebSiteResult result = new MultiWebSiteResult { Url = targetUrl };
            //    results.Enqueue(result);
            //    RegisterAsyncTask(new PageAsyncTask(async () =>
            //    {
            //        result.StartTime = (long)DateTime.Now
            //            .Subtract(Context.Timestamp).TotalMilliseconds;
            //        string webContent =
            //            await new WebClient().DownloadStringTaskAsync(targetUrl);
            //        result.Length = webContent.Length;
            //        rep.DataBind();
            //    }));
            //}
        }

        public IEnumerable<MultiWebSiteResult> GetResults()
        {
            return results;
        }
    }
}