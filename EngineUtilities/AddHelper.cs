using System;
using System.Collections.Generic;
using System.Runtime.Caching;
namespace Istianne_Izzy.EngineUtilities
{
    public static class AddHelper
    {
        public static bool Add<T>(string CacheName,T Data)
        {
            List<T> DataList = GetHelper.Get<T>(CacheName);
            DataList.Add(Data);
            ObjectCache cache = MemoryCache.Default;
            try
            {
                cache.Remove(CacheName);
                CacheItemPolicy policy = new CacheItemPolicy { AbsoluteExpiration = DateTimeOffset.Now.AddHours(1000) };
                cache.Add(CacheName, DataList, policy);
                return true;
            }
            catch (Exception)
            {
                return false;
            }            
        }
    }
}
