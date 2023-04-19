namespace Sliit.MTIT.Manager.Services
{
    public interface IManagerService
    {
        List<Models.Manager> GetManagers();

        Models.Manager? GetManager(int id);

        Models.Manager? AddManager(Models.Manager manager);

        Models.Manager? UpdateManager(Models.Manager manager);

        bool? DeleteManager(int id);
    }
}
