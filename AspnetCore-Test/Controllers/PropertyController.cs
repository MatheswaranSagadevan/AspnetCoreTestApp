using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test_BusinessService.Interface;
using Test_BusinessService.ServiceObjects;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspnetCore_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService propertyService;
            public PropertyController(IPropertyService propertyService)
            {
                this.propertyService = propertyService;
            }
        // GET: api/<PropertyController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PropertyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PropertyController>
        [HttpPost]
        public IActionResult Post([FromBody] PropertySO propertySO)
        {
            try
            {
                this.propertyService.SavePropertyInfo(propertySO);
                return Ok(1);
            }
            catch(Exception e)
            {
                if (e.Message.Contains("Property does not exist")) {
                    return NotFound();
                }
                throw;
            }
        }

        // PUT api/<PropertyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PropertyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
