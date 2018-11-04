

namespace Istianne_Izzy
{
    public static class Operation
    {
       // Below are some sample operation that involved in Cache Specific Operation that is used in Business Logics
       
        public static string CompletedOrderToken_AsCompleted
        {
            get{ return "CompletedOrderToken_AsCompleted"; }
        }
        public static string CompletedOrderToken_AsIsOutForDelivery
        {
            get{ return "CompletedOrderToken_AsIsOutForDelivery"; }
        }
        public static string CompletedOrderToken_AsIsPickedUpByCustomerService
        {
            get{ return "CompletedOrderToken_AsIsPickedUpByCustomerService"; }
        }
        public static string CompletedOrderToken_AsIsPickedUpByStoreManager
        {
            get{ return "CompletedOrderToken_AsIsPickedUpByStoreManager"; }
        }      
        public static string CustomerOrder_AsIsPaid
        {
            get{ return "CustomerOrder_AsIsPaid"; }
        }
        public static string CustomerOrder_AsIsPassedToDeliveryTeam
        {
            get{ return "CustomerOrder_AsIsPassedToDeliveryTeam"; }
        }
        public static string SalesItem_AsIsOnline
        {
            get{ return "SalesItem_AsIsOnline"; }
        }
        public static string SalesItem_AsIsOffline
        {
            get{ return "SalesItem_AsIsOffline"; }
        }
        public static string SalesItem_AsIsDeleted
        {
            get{ return "SalesItem_AsIsDeleted"; }
          
        }
    }
}
