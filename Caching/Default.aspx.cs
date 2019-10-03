using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;

namespace Caching
{
    public partial class Default : System.Web.UI.Page
    {
        private static readonly string CACHE_KEY = "codebehind_ts";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string GetTime()
        {
            string ts = (string)Cache[CACHE_KEY];
            if (ts == null)
            {
                //Cache[CACHE_KEY] = ts = DateTime.Now.ToLongTimeString();
                //ts = DateTime.Now.ToLongTimeString();
                //Cache.Insert(CACHE_KEY, ts, null,
                //    Cache.NoAbsoluteExpiration, TimeSpan.FromSeconds(5),
                //    CacheItemPriority.Normal, HandleRemoveNotification);
                ts = UpdateCache();
            }
            else
            {
                ts += "<b>(Cached)</b> ";
            }
            return ts;
        }

        private string UpdateCache()
        {
            string ts = DateTime.Now.ToLongTimeString();
            Cache.Insert(CACHE_KEY, ts, null,
                Cache.NoAbsoluteExpiration, TimeSpan.FromSeconds(10),
                HandleUpdateNotification);
            return ts;
        }

        private void HandleUpdateNotification(string key, 
            CacheItemUpdateReason reason, 
            out object expensiveObject, 
            out CacheDependency dependency, 
            out DateTime absoluteExpiration, 
            out TimeSpan slidingExpiration)
        {
            expensiveObject = dependency = null;
            slidingExpiration = Cache.NoSlidingExpiration;
            absoluteExpiration = Cache.NoAbsoluteExpiration;

            if (reason ==  CacheItemUpdateReason.Expired)
            {
                expensiveObject = DateTime.Now.ToLongTimeString();
                slidingExpiration = TimeSpan.FromSeconds(10);
                System.Diagnostics.Debug.WriteLine("Item {0} updated", key);
            }
        }

        private void HandleRemoveNotification(string key, object value, CacheItemRemovedReason reason)
        {
            if (reason == CacheItemRemovedReason.Expired)
            {
                UpdateCache();
                System.Diagnostics.Debug.WriteLine("Cache item {0} ejected {1}",
                key, reason);
            }
        }
    }
}