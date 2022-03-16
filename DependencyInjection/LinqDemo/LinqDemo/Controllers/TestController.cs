using LinqDemo.DemoLinq;
using LinqDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqDemo.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class TestController : Controller
        
    {
        private readonly TestServices _testServices = null;
        public TestController(TestServices testServices)
        {
            _testServices = testServices;

        }
        [HttpGet]
        public ActionResult Stud()
        {
            try
            {


                //TestRepository tr = new TestRepository();

                List<Student> details = _testServices.Stud();
                return Ok(details);
            }
            catch
            {
                return NoContent();
            }
            }
        [HttpGet]
        public IActionResult GetAllStudent(int Rollno)
        {
            try
            {
                //TestRepository tr = new TestRepository();
                Student details = _testServices.GetStudId(Rollno);
                return Ok(details);
            }
            catch
            {
                return NoContent();
            }
        
            
        }

    }
}
