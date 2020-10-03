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
    public class CampController : Controller
    {
        private readonly ICamp objCamp;

        public CampController(ICamp _objCamp)
        {
            objCamp = _objCamp;
        }

        [HttpGet]
        [Route("All")]
        public IEnumerable<Camp> Index()
        {
            return objCamp.GetAllCamps();
        }

        [HttpPost]
        [Route("Create")]
        public void Create([FromBody] Camp Camp)
        {
            if (ModelState.IsValid)
                objCamp.AddCamp(Camp);
        }

        [HttpGet]
        [Route("Details/{id}")]
        public Camp Details(int id)
        {

            return objCamp.GetCampData(id);
        }

        [HttpPut]
        [Route("Edit")]
        public void Edit([FromBody]Camp Camp)
        {
            if (ModelState.IsValid)
                objCamp.UpdateCamp(Camp);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            objCamp.DeleteCamp(id);
        }
    }
}
