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
    public class TeacherController : Controller
    {
        private readonly ITeacher objteacher;

        public TeacherController(ITeacher _objteacher)
        {
            objteacher = _objteacher;
        }

        [HttpGet]
        [Route("All")]
        public IEnumerable<Teacher> Index()
        {
            return objteacher.GetAllTeachers();
        }

        [HttpPost]
        [Route("Create")]
        public void Create([FromBody] Teacher teacher)
        {
            if (ModelState.IsValid)
                objteacher.AddTeacher(teacher);
        }

        [HttpGet]
        [Route("Details/{id}")]
        public Teacher Details(int id)
        {

            return objteacher.GetTeacherData(id);
        }

        [HttpPut]
        [Route("Edit")]
        public void Edit([FromBody]Teacher teacher)
        {
            if (ModelState.IsValid)
                objteacher.UpdateTeacher(teacher);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            objteacher.DeleteTeacher(id);
        }
    }
}
