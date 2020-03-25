using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OpenVentilatorRegistryWeb
{
    [Route("api/[controller]")]
    public class HospitalController : Controller
    {
        /// <summary>
        /// Gets a list of hospitals.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesDefaultResponseType]
        [HttpGet("list")]
        [ProducesResponseType(204)]
        public IEnumerable<Hospital> Get()
        {
            return new List<Hospital>();
        }

        /// <summary>
        /// Gets a Hospital by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(204)]
        public Hospital Get(int id)
        {
            return new Hospital();
        }

        /// <summary>
        /// Creates a new hospital.
        /// </summary>
        /// <param name="hospital"></param>
        [HttpPost]
        [ProducesDefaultResponseType]
        [ProducesResponseType(400)]
        public void Post([FromBody]Hospital hospital)
        {
        }

        /// <summary>
        /// Updates a hospital.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        [ProducesDefaultResponseType]
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Deletes a hospital.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        [ProducesDefaultResponseType]
        public void Delete(int id)
        {
        }
    }
}
