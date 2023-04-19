namespace Sliit.MTIT.Transport.Data
{
    public static class TransportMockDataService
    {
        public static List<Models.Transport> Transports = new List<Models.Transport>()
        {
            new Models.Transport { Id=1, TransportName = "ABCD", Location = "Colombo", VehicalNo = "AB2356"},
            new Models.Transport { Id=2, TransportName = "Nike", Location = "Galle", VehicalNo = "ZD3567"},
            new Models.Transport { Id=3, TransportName = "DSI", Location = "Matara", VehicalNo = "HP7689"},
            new Models.Transport { Id=4, TransportName = "Bata", Location = "Kandy", VehicalNo = "PP7765"},
            new Models.Transport { Id=5, TransportName = "ODel", Location = "Gampaha", VehicalNo = "YT7788"},

        };
    }
}
