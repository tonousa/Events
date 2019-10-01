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
        private string CACHE_KEY = "codebehind_ts";

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
                ts += "<b>(Cache)</b>";
            }
            return ts;
        }

        private string UpdateCache()
        {
            string ts = DateTime.Now.ToLongTimeString();
            Cache.Insert(CACHE_KEY, ts, null,
                Cache.NoAbsoluteExpiration, TimeSpan.FromSeconds(10),
                CacheItemPriority.Normal, HandleRemoveNotification);
            return ts;
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