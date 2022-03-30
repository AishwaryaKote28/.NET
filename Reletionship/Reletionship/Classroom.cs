using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reletionship
{
    public class Classroom
    {
        [Key]
        public int Id { get; set; }

        public String Number { get; set; }
        //one to many relationship with student
       public ICollection<Student> Students { get; set; }
        //one to one
        public Teacher Teacher { get; set; }
    }
}
