using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Transport.Data;
using Sliit.MTIT.Transport.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Transport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportController : ControllerBase
    {
        private readonly ITransportService _transportService;

        public TransportController(ITransportService transportService)
        {
            _transportService = transportService ?? throw new ArgumentNullException(nameof(transportService));
        }


        /// <summary>
        /// Get all transports
        /// </summary>
        /// <returns>return the list of transports</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_transportService.GetTransports());
        }

        /// <summary>
        /// Get transport by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the transport with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _transportService.GetTransport(id) != null ? Ok(_transportService.GetTransport(id)) : NoContent();
        }

        /// <summary>
        /// Add transports
        /// </summary>
        /// <param name="transport"></param>
        /// <returns>Return the added transport</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Transport transport)
        {
            return Ok(_transportService.AddTransport(transport));
        }

        /// <summary>
        /// Update the transport
        /// </summary>
        /// <param name="transport"></param>
        /// <returns>Return the updated transport</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Transport transport)
        {
            return Ok(_transportService.UpdateTransport(transport));
        }

        /// <summary>
        /// Delete the v with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _transportService.DeleteTransport(id);

            return result.HasValue & result == true ? Ok($"transport with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the transport with ID:{id}.");
        }
    }
}
