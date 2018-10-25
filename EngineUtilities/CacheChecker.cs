
namespace Istianne_Izzy.EngineUtilities
{
    public static class CacheChecker
    {
        public static bool Check<T>(string CacheName, T Data)
        {
            if(GetHelper.Get<T>(CacheName) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
