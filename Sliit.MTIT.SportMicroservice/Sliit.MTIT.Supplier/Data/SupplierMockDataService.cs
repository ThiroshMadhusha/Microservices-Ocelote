namespace Sliit.MTIT.Supplier.Data
{
    public static class SupplierMockDataService
    {
        public static List<Models.Supplier> Suppliers = new List<Models.Supplier>()
        {
            new Models.Supplier { Id=1, SupplierName = "Thirosh", SportItemName = "Cricket Bat", SportItemPrice = 12324},
            new Models.Supplier { Id=2, SupplierName = "Sachini", SportItemName = "Basket Ball", SportItemPrice = 4223},
            new Models.Supplier { Id=3, SupplierName = "Kasuni", SportItemName = "Swimming Kit", SportItemPrice = 4522},
            new Models.Supplier { Id=4, SupplierName = "Apsara", SportItemName = "Leather Bat", SportItemPrice = 13321},
            new Models.Supplier { Id=5, SupplierName = "Nethuki", SportItemName = "Hockey Ball", SportItemPrice = 4520},

        };
    }
}
