using BlazorCrud.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.Interfaces
{
    public interface IUDate
    {
        public IEnumerable<UDate> GetAllUDates();
        public void AddUDate(UDate UDate);
        public void UpdateUDate(UDate UDate);
        public UDate GetUDateData(int id);
        public void DeleteUDate(int id);
    }
}
