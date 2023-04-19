using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Manager.Data;
using Sliit.MTIT.Manager.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Manager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IManagerService _managerService;

        public ManagerController(IManagerService managerService)
        {
            _managerService = managerService ?? throw new ArgumentNullException(nameof(managerService));
        }


        /// <summary>
        /// Get all Managers
        /// </summary>
        /// <returns>return the list of Managers</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_managerService.GetManagers());
        }

        /// <summary>
        /// Get Manager by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the Manager with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _managerService.GetManager(id) != null ? Ok(_managerService.GetManager(id)) : NoContent();
        }

        /// <summary>
        /// Add Managers
        /// </summary>
        /// <param name="manager"></param>
        /// <returns>Return the added manager</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Manager manager)
        {
            return Ok(_managerService.AddManager(manager));
        }

        /// <summary>
        /// Update the manager
        /// </summary>
        /// <param name="manager"></param>
        /// <returns>Return the updated manager</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Manager manager)
        {
            return Ok(_managerService.UpdateManager(manager));
        }

        /// <summary>
        /// Delete the manager with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _managerService.DeleteManager(id);

            return result.HasValue & result == true ? Ok($"manager with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the manager with ID:{id}.");
        }
    }
}