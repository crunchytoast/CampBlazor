using BlazorCrud.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.Interfaces
{
    public interface IStudent
    {
        public IEnumerable<Student> GetAllStudents();
        public void AddStudent(Student Student);
        public void UpdateStudent(Student Student);
        public Student GetStudentData(int id);
        public void DeleteStudent(int id);
    }
}
