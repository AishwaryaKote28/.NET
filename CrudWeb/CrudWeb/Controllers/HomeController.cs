using CrudWeb.Infra;
using CrudWeb.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWeb.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly IProducts _repo;

        public HomeController(IProducts repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("Index")]

        public IActionResult Index()
        {
            var prod = _repo.GetProducts();
            return Ok(prod);
        }
        [HttpGet]
        public IActionResult Create()
        {

            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Products products)
        {
            _repo.Create(products);
            return Ok();

        }
    }
}
