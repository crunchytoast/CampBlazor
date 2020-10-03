using BlazorCrud.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.Interfaces
{
    public interface ITeacher
    {
        public IEnumerable<Teacher> GetAllTeachers();
        public void AddTeacher(Teacher Teacher);
        public void UpdateTeacher(Teacher Teacher);
        public Teacher GetTeacherData(int id);
        public void DeleteTeacher(int id);
    }
}
