using BlazorCrud.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.Interfaces
{
    public interface IClass
    {
        public IEnumerable<Class> GetAllClasses();
        public void AddClass(Class Class);
        public void UpdateClass(Class Class);
        public Class GetClassData(int id);
        public void DeleteClass(int id);
    }
}
