using CrudWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWeb.Infra
{
    public interface IProducts
    {
        public List<Products> GetProducts();
        public Products GetProduct(int Id);
        public void Create(Products product);
    }
}
