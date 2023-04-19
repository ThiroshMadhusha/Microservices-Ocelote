namespace Sliit.MTIT.Store.Services
{
    public interface IStoreService
    {
        List<Models.Store> GetStores();

        Models.Store? GetStore(int id);

        Models.Store? AddStore(Models.Store store);

        Models.Store? UpdateStore(Models.Store store);

        bool? DeleteStore(int id);
    }
}
