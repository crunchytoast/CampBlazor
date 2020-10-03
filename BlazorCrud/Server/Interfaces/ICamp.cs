using BlazorCrud.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.Interfaces
{
    public interface ICamp
    {
        public IEnumerable<Camp> GetAllCamps();
        public void AddCamp(Camp Camp);
        public void UpdateCamp(Camp Camp);
        public Camp GetCampData(int id);
        public void DeleteCamp(int id);
    }
}
