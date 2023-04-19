using Sliit.MTIT.Supplier.Data;
using Sliit.MTIT.Supplier.Models;

namespace Sliit.MTIT.Supplier.Services
{
    public class SupplierService : ISupplierService
    {
        public List<Models.Supplier> GetSuppliers()
        {
            return SupplierMockDataService.Suppliers;
        }

        public Models.Supplier? GetSupplier(int id)
        {
            return SupplierMockDataService.Suppliers.FirstOrDefault(x => x.Id == id);
        }

        public Models.Supplier? AddSupplier(Models.Supplier supplier)
        {
            SupplierMockDataService.Suppliers.Add(supplier);
            return supplier;
        }

        public Models.Supplier? UpdateSupplier(Models.Supplier supplier)
        {
            Models.Supplier selectedSupplier = SupplierMockDataService.Suppliers.FirstOrDefault(x => x.Id == supplier.Id);
            if (selectedSupplier != null)
            {
                selectedSupplier.SportItemName = supplier.SportItemName;
                selectedSupplier.SportItemPrice = supplier.SportItemPrice;
                selectedSupplier.SupplierName = supplier.SupplierName;
                return selectedSupplier;
            }

            return selectedSupplier;
        }

        public bool? DeleteSupplier(int id)
        {
            Models.Supplier selectedSupplier = SupplierMockDataService.Suppliers.FirstOrDefault(x => x.Id == id);
            if (selectedSupplier != null)
            {
                SupplierMockDataService.Suppliers.Remove(selectedSupplier);
                return true;
            }
            return false;
        }
    }
}
