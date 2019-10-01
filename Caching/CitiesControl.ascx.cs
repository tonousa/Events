using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching
{
    //public class CitiListInfo
    //{
    //    public string Timestamp { get; set; }
    //    public string Html { get; set; }
    //}

    public partial class CitiesControl : System.Web.UI.UserControl
    {
        private static readonly string fileName = "/CitiesList.html";
        private static readonly string TIME_CACHE_KEY = "cities_time";
        private static readonly string HTML_CACHE_KEY = "cities_html";
        //private CitiListInfo cityInfo;
        private bool cached = false;

        public string GetCities()
        {
            string html = Cache[HTML_CACHE_KEY] as string;
            if (html == null)
            {
                html = File.ReadAllText(MapPath(fileName));
                //Cache.Insert(HTML_CACHE_KEY, html,
                //    new RequestCountDependency(3));
                AggregateCacheDependency aggDep = new AggregateCacheDependency();
                aggDep.Add(new CacheDependency(MapPath(fileName)));
                aggDep.Add(new RequestCountDependency(3));
                Cache.Insert(HTML_CACHE_KEY, html, aggDep);
            }
            else
            {
                cached = true;
            }
            return html;
        }

        public string GetTimeStamp()
        {
            string timeStamp = (string)Cache[TIME_CACHE_KEY];
            if (timeStamp == null)
            {
                timeStamp = DateTime.Now.ToLongTimeString();
                Cache.Insert(TIME_CACHE_KEY, timeStamp,
                    new CacheDependency(null, new string[] { HTML_CACHE_KEY }));
            }
            return timeStamp + (cached ? "<b>Cached</b>" : "");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}