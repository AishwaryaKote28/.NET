using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqDemo.DemoLinq
{
    public class TestRepository : ITestRepository
    {
        public List<Student> DataSource()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Rollno=1,
                    name="shruti",
                    division="nagar"
                },
            new Student()
            {
                Rollno= 2,
                name = "aishwarya",
                division = "solapur"
            },
            new Student()
            {
                Rollno = 3,
                name = "shreyas",
                division = "nashik"
            },
            new Student()
            {
                Rollno = 4,
                name = "rutuja",
                division = "pune"
            },
        };
        }
        public Student GetAllStudent(int Rollno)
        {
            return DataSource().First(rt => rt.Rollno == Rollno);
        }
        public List<Student> Stud()
        {
            return DataSource();
        }
    }
}

