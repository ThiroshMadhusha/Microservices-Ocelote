using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Supplier.Data;
using Sliit.MTIT.Supplier.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Supplier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService ?? throw new ArgumentNullException(nameof(supplierService));
        }


        /// <summary>
        /// Get all suppliers
        /// </summary>
        /// <returns>return the list of suppliers</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_supplierService.GetSuppliers());
        }

        /// <summary>
        /// Get supplier by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the supplier with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _supplierService.GetSupplier(id) != null ? Ok(_supplierService.GetSupplier(id)) : NoContent();
        }

        /// <summary>
        /// Add suppliers
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns>Return the added supplier</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Supplier supplier)
        {
            return Ok(_supplierService.AddSupplier(supplier));
        }

        /// <summary>
        /// Update the supplier
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns>Return the updated supplier</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Supplier supplier)
        {
            return Ok(_supplierService.UpdateSupplier(supplier));
        }

        /// <summary>
        /// Delete the supplier with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _supplierService.DeleteSupplier(id);

            return result.HasValue & result == true ? Ok($"supplier with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the supplier with ID:{id}.");
        }
    }
}