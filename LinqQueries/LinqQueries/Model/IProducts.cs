using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqQueries.Model
{
   public interface IProducts
    {
        public List<Products> GetProducts();
        public Products GetProduct(int PId);
        public void AddProduct(Products Products);
        
        public List<Products> GetName();
        public List<Products> GetPrice();
    }
}
