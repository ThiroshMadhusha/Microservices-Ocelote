namespace Sliit.MTIT.Supplier.Services
{
    public interface ISupplierService
    {
        List<Models.Supplier> GetSuppliers();

        Models.Supplier? GetSupplier(int id);

        Models.Supplier? AddSupplier(Models.Supplier supplier);

        Models.Supplier? UpdateSupplier(Models.Supplier supplier);

        bool? DeleteSupplier(int id);
    }
}
