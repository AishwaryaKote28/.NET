using LinqQueries.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqQueries.Services
{
    public class ProductsService
    {
        IProducts _pservice;
        public ProductsService(IProducts service)
        {
            _pservice = service;
        }
        public List<Products> GetProducts()
        {
            List<Products> products = _pservice.GetProducts();
            return products.OrderBy(t => t.PName).ToList();


        }
        public Products GetProduct(int ID)
        {
            return _pservice.GetProduct(ID);

        }
        public void AddProduct(Products product)
        {
            _pservice.AddProduct(product);
        }
        
        public List<Products> GetName()
        {
            List<Products> Products = _pservice.GetName();
            return Products.Where(s => s.Price >= 500).ToList();





        }
    }
}
