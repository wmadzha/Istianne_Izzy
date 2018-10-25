using System;
using System.Collections.Generic;
using System.Runtime.Caching;

namespace Istianne_Izzy.EngineUtilities
{
    public static class Helper
    {
        public static bool CastCache<T>(string CacheName , List<T> Data)
        {
            try
            {
                ObjectCache cache = MemoryCache.Default;
                try
                {
                    cache.Remove(CacheName);
                }
                catch (Exception)
                {
                }
                CacheItemPolicy policy = new CacheItemPolicy { AbsoluteExpiration = DateTimeOffset.Now.AddHours(1000) };
                cache.Add(CacheName, Data, policy);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
