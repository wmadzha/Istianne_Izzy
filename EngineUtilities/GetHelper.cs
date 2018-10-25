
using System.Collections.Generic;
using System.Runtime.Caching;
namespace Istianne_Izzy.EngineUtilities
{
    public static class GetHelper
    {
        public static List<T> Get<T>(string CacheName)
        {
            ObjectCache cache = MemoryCache.Default;
            List<T> Data = cache.Get(CacheName) as List<T>;
            return Data;
        }
    }
}
