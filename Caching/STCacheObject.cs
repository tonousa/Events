using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace Caching
{
    public class STCacheObject<T>
    {
        private int accessedCounter = 0;
        private int renewThreshold, renewDurationMins;
        private T dataObject;
        private Func<T> updateCallback;

        public T Data
        {
            get
            {
                accessedCounter++;
                return dataObject;
            }
        }

        public DateTime Expiry {
            get {
                return DateTime.Now.AddSeconds(1000);
            }
        }

        public STCacheObject(string key, Func<T> callback, int threshold = 100,
            int duration = 60)
        {
            updateCallback = callback;
            dataObject = updateCallback();
            renewThreshold = threshold;
            renewDurationMins = duration;

            HttpContext.Current.Cache.Insert(key, this, null,
                Expiry, Cache.NoSlidingExpiration, HandleUpdateCallback);
        }

        private void HandleUpdateCallback(string key, CacheItemUpdateReason reason, 
            out object expensiveObject, out CacheDependency dependency, 
            out DateTime absoluteExpiration, out TimeSpan slidingExpiration)
        {
            bool renew = accessedCounter >= renewThreshold;
            if (renew)
            {
                dataObject = updateCallback();
                accessedCounter = 0;
            }

            expensiveObject = renew ? this : null;
            dependency = null;
            absoluteExpiration = renew ? Expiry : Cache.NoAbsoluteExpiration;
            slidingExpiration = Cache.NoSlidingExpiration;
        }
    }
}