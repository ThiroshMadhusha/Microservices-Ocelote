namespace Sliit.MTIT.Manager.Data
{
    public static class ManagerMockDataService
    {
        public static List<Models.Manager> Managers = new List<Models.Manager>()
        {
            new Models.Manager { Id=1, ManagerName = "Thirosh", BranchName = "TDSM 1", Location = "Galle"},
            new Models.Manager { Id=2, ManagerName = "Sachini", BranchName = "TDSM 2", Location = "Kandy"},
            new Models.Manager { Id=3, ManagerName = "Kasuni", BranchName = "TDSM 3", Location = "Jafna"},
            new Models.Manager { Id=4, ManagerName = "Apsara", BranchName = "TDSM 4", Location = "Colombo"},
            new Models.Manager { Id=5, ManagerName = "Nethuki", BranchName = "TDSM 5", Location = "Gampaha"},

        };
    }
}
