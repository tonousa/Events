using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace Caching
{
    public class CustomOutputCache : OutputCacheProvider
    {
        private ConcurrentDictionary<string, CacheItem> cache;

        public CustomOutputCache() : base()
        {
            cache = new ConcurrentDictionary<string, CacheItem>();

        }
    }

    class CacheItem
    {
        public object Data { get; set; }
        public DateTime Expiry { get; set; }
        public bool Expires {
            get {
                return DateTime.UtcNow > Expiry;
            }
        }
    }
}