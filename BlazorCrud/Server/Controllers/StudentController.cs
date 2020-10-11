using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrud.Server.Interfaces;
using BlazorCrud.Shared.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorCrud.Server.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudent objStudent;

        public StudentController(IStudent _objStudent)
        {
            objStudent = _objStudent;
        }

        [HttpGet]
        [Route("All")]
        public IEnumerable<Student> Index()
        {
            return objStudent.GetAllStudents();
        }

        [HttpPost]
        [Route("Create")]
        public void Create([FromBody] Student Student)
        {
            if (ModelState.IsValid)
                objStudent.AddStudent(Student);
        }

        [HttpGet]
        [Route("Details/{id}")]
        public Student Details(int id)
        {

            return objStudent.GetStudentData(id);
        }

        [HttpPut]
        [Route("Edit")]
        public void Edit([FromBody] Student Student)
        {
            if (ModelState.IsValid)
                objStudent.UpdateStudent(Student);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            objStudent.DeleteStudent(id);
        }
    }
}
