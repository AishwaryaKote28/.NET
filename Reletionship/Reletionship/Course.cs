using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reletionship
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public String CoursNamee { get; set; }
        //manyto many relationship with student
        public ICollection<Student> Students { get; set; }
        //one to one
    } 
}

