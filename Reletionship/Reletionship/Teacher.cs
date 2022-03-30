using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reletionship
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public int ClassroomId { get; set; }

        //one to one relationship
        public Classroom Classroom { get; set; }
    }
}
    

