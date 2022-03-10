using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstDemoController : ControllerBase
    {
        // GET: api/<FirstDemoController>



        public static List<string> Employees = new List<string>()
        {
             "ankita","anish"
        };


        //GET: api/<FirstDemoControlle>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Employees.ToList();
        }

        // after calling get the output is an empty array like this []

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Employees[id];
        }


        // POST api/<FirstDemoControlle>



        [HttpPost]
        public void Post([FromBody] string value)
        {
            Employees.Add(value);

        }


        // PUT api/<FirstDemoControlle>/5


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            Employees[id] = value;
        }



        // DELETE api/<FirstDemoControlle>

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Employees.RemoveAt(id);
        }
    }
}
