using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LinqQueries.Model
{
    public class Products
    {
        [Key]
        public int Pid { get; set; }
        public string PName { get; set; }
        public double Price { get; set; }
    }
}
