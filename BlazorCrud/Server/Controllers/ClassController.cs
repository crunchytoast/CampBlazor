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
    public class ClassController : Controller
    {
        private readonly IClass objClass;

        public ClassController(IClass _objClass)
        {
            objClass = _objClass;
        }

        [HttpGet]
        [Route("All")]
        public IEnumerable<Class> Index()
        {
            return objClass.GetAllClasses();
        }

        [HttpPost]
        [Route("Create")]
        public void Create([FromBody] Class Class)
        {
            if (ModelState.IsValid)
                objClass.AddClass(Class);
        }

        [HttpGet]
        [Route("Details/{id}")]
        public Class Details(int id)
        {

            return objClass.GetClassData(id);
        }

        [HttpPut]
        [Route("Edit")]
        public void Edit([FromBody] Class Class)
        {
            if (ModelState.IsValid)
                objClass.UpdateClass(Class);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            objClass.DeleteClass(id);
        }
    }
}
