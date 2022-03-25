using LinqQueries.Model;
using LinqQueries.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqQueries.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        ProductsService _repo;
        public HomeController(ProductsService repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            var prod = _repo.GetProducts();
            return Ok(prod);
        }
        [HttpGet]
        [Route("GetName")]
        public IActionResult GetName()
        {

            var t = _repo.GetName();
            return Ok(t);
        }
        [HttpGet]
        [Route("AddProduct")]
        public IActionResult AddProduct()
        {
            return Ok();
        }

        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddTeacher(Products tea)
        {
            _repo.AddProduct(tea);
            return Ok();

        }

        

    }
}
