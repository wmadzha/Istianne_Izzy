using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using AnyApp_DataAccess;

namespace Istianne_Izzy.Init
{
    public static class BookingSlotClientCache
    {
        public static bool Startup()
        {
            return EngineUtilities.Helper.CastCache("BookingSlotClient", AnyApp_DataAccess.BookingSlotClients.Get.List.All());
        }
    }
}
