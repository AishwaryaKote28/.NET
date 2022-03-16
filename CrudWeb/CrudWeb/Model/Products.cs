using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWeb.Model
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Quality { get; set; }
    }
}
