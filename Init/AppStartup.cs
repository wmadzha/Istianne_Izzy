
using System.Threading.Tasks;

namespace Istianne_Izzy.Init
{
    public static class AppStartup
    {
        public static void Start()
        {
            // Assuming That After Initialization, This App  need to load its BookingSlotClient Object into its Cache
            Task BookingSlotClient = new Task(() => BookingSlotClientCache.Startup());
            BookingSlotClient.Start();            
        }
    }
}
