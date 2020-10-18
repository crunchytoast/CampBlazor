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
    public class UDateController : Controller
    {
        private readonly IUDate objUDate;

        public UDateController(IUDate _objUDate)
        {
            objUDate = _objUDate;
        }

        [HttpGet]
        [Route("All")]
        public IEnumerable<UDate> Index()
        {
            return objUDate.GetAllUDates();
        }

        [HttpPost]
        [Route("Create")]
        public void Create([FromBody] UDate UDate)
        {
            if (ModelState.IsValid)
                objUDate.AddUDate(UDate);
        }

        [HttpGet]
        [Route("Details/{id}")]
        public UDate Details(int id)
        {

            return objUDate.GetUDateData(id);
        }

        [HttpPut]
        [Route("Edit")]
        public void Edit([FromBody] UDate UDate)
        {
            if (ModelState.IsValid)
                objUDate.UpdateUDate(UDate);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            objUDate.DeleteUDate(id);
        }
    }
}
