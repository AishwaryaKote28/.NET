using LinqDemo.DemoLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqDemo.Services
{
    public class TestServices
    {
        //Creating Dependency Injection

        private readonly ITestRepository _repo = null;
        public TestServices(ITestRepository repo)
        {
            _repo = repo;
        }

        public List<Student> Stud()
        {
            return _repo.Stud();
        }
        public Student GetStudId(int id)
        {
            return _repo.GetAllStudent(id);
        }
    }
}
