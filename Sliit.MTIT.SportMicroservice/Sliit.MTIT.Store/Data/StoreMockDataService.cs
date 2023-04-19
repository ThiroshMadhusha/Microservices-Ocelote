namespace Sliit.MTIT.Store.Data
{
    public static class StoreMockDataService
    {
        public static List<Models.Store> Stores = new List<Models.Store>()
        {
            new Models.Store { Id=1, StoreName = "Store 1", ItemName = "Cricket Items", ItemQuantity = 240},
            new Models.Store { Id=2, StoreName = "Store 2", ItemName = "Football Items", ItemQuantity = 523},
            new Models.Store { Id=3, StoreName = "Store 3", ItemName = "Rugby Items", ItemQuantity = 622},
            new Models.Store { Id=4, StoreName = "Store 4", ItemName = "Swimming Items", ItemQuantity = 321},
            new Models.Store { Id=5, StoreName = "Store 5", ItemName = "Hockey Items", ItemQuantity = 120},

        };
    }
}
