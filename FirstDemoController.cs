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

        public List<string> Employees = new List<string>()
       {
           "Ankita","Sanvi","Rohit","Sayali"
       };
        [HttpGet]
        
        public IEnumerable<string> GetEmployeesDetail()
        {
            return Employees;
        }

        // GET api/<FirstDemoController>/5
        [HttpGet("{id}")]
        public string GetEmployeeByIndex(int id)
        {
            return Employees[id];
        }

        // POST api/<FirstDemoController>
       
        [HttpPost]
        public void PostEmployeDetail([FromBody] string value)
        {
            Employees.Add(value);
            
        }

        // PUT api/<FirstDemoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            Employees[id] = value;
        }

        // DELETE api/<FirstDemoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Employees.RemoveAt(id); 
        }
    }
}
