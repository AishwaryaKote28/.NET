using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqDemo.DemoLinq
{
    interface ITestRepository
    {
        Student GetAllStudent(int id);
        List<Student> Stud();
    }
}
