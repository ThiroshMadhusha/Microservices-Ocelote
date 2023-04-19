using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Store.Data;
using Sliit.MTIT.Store.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService ?? throw new ArgumentNullException(nameof(storeService));
        }


        /// <summary>
        /// Get all stores
        /// </summary>
        /// <returns>return the list of stores</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_storeService.GetStores());
        }

        /// <summary>
        /// Get store by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the store with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _storeService.GetStore(id) != null ? Ok(_storeService.GetStore(id)) : NoContent();
        }

        /// <summary>
        /// Add stores
        /// </summary>
        /// <param name="store"></param>
        /// <returns>Return the added store</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Store store)
        {
            return Ok(_storeService.AddStore(store));
        }

        /// <summary>
        /// Update the store
        /// </summary>
        /// <param name="store"></param>
        /// <returns>Return the updated store</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Store store)
        {
            return Ok(_storeService.UpdateStore(store));
        }

        /// <summary>
        /// Delete the v with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _storeService.DeleteStore(id);

            return result.HasValue & result == true ? Ok($"store with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the store with ID:{id}.");
        }
    }
}
