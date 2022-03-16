using CrudWeb.Infra;
using CrudWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWeb
{
    public class ProductsRepo : IProducts
    {
        public DatabaseContext _context;
        public ProductsRepo(DatabaseContext context)
        {
            _context = context;
        }
        public List<Products> GetProducts()
        {
            return _context.Products.ToList();

        }
        public Products GetProduct(int Id)
        {
            return _context.Products.FirstOrDefault(st => st.Id == st.Id);
        }
        public void Create(Products products)
        {
            _context.Add(products);
            _context.SaveChanges();
        }

       

    }
}
