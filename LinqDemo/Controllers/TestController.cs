using LinqDemo.DemoLinq;
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
        [HttpGet]
        public ActionResult Stud()
        {
            TestRepository tr = new TestRepository();
            List<Student> details = tr.Stud();
            return Ok(details); 
        }
        [HttpGet]
        public IActionResult GetAllStudent(int Rollno)
        { 
        
            TestRepository tr = new TestRepository();
            Student details = tr.GetAllStudent(Rollno);
            return Ok(details);
        }

    }
}
