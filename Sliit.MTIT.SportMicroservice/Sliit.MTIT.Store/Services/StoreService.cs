using Sliit.MTIT.Store.Data;
using Sliit.MTIT.Store.Models;

namespace Sliit.MTIT.Store.Services
{
    public class StoreService : IStoreService
    {
        public List<Models.Store> GetStores()
        {
            return StoreMockDataService.Stores;
        }

        public Models.Store? GetStore(int id)
        {
            return StoreMockDataService.Stores.FirstOrDefault(x => x.Id == id);
        }

        public Models.Store? AddStore(Models.Store store)
        {
            StoreMockDataService.Stores.Add(store);
            return store;
        }

        public Models.Store? UpdateStore(Models.Store store)
        {
            Models.Store selectedStore = StoreMockDataService.Stores.FirstOrDefault(x => x.Id == store.Id);
            if (selectedStore != null)
            {
                selectedStore.ItemName = store.ItemName;
                selectedStore.ItemQuantity = store.ItemQuantity;
                selectedStore.StoreName = store.StoreName;
                return selectedStore;
            }

            return selectedStore;
        }

        public bool? DeleteStore(int id)
        {
            Models.Store selectedStore = StoreMockDataService.Stores.FirstOrDefault(x => x.Id == id);
            if (selectedStore != null)
            {
                StoreMockDataService.Stores.Remove(selectedStore);
                return true;
            }
            return false;
        }
    }
}
