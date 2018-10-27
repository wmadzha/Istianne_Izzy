
using System.Threading.Tasks;

namespace Istianne_Izzy.Init
{
    public static class AppStartup
    {
        public static void Start()
        {
            // Assuming That After Initialization, This App is need to load its BookingSlotClientCache Object.
            Task BookingSlotClient = new Task(() => BookingSlotClientCache.Startup());
            BookingSlotClient.Start();            
        }
    }
}
