using LinqQueries.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqQueries.Model
{
    public class ProductsRepo : IProducts
    {
        DataBaseContext _context;
        public ProductsRepo(DataBaseContext context)
        {
            _context = context;
        }
        public List<Products> GetProducts()
        {
            return _context.Products.ToList();

        }
        public Products GetProduct(int PId)
        {
            return _context.Products.FirstOrDefault(e => e.Pid == PId);

        }
        public void AddProduct(Products Products)

        {
            _context.Add(Products);
            _context.SaveChanges();
        }

        public List<Products> GetName()
        {
            return _context.Products.ToList();
        }
        public List<Products> GetPrice()
        {
            return _context.Products.ToList();
        }

    }
}
