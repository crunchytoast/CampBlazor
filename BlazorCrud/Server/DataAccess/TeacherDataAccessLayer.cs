using BlazorCrud.Server.Interfaces;
using BlazorCrud.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.DataAccess
{
    public class TeacherDataAccessLayer: ITeacher
    {
        private CampDbContext db;

        public TeacherDataAccessLayer(CampDbContext ctx)
        {
            db = ctx;
        }

        //To Get all teachers details   
        public IEnumerable<Teacher> GetAllTeachers()
        {
            try
            {
                return db.Teacher.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new teacher record     
        public void AddTeacher(Teacher teacher)
        {
            try
            {
                db.Teacher.Add(teacher);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee    
        public void UpdateTeacher(Teacher teacher)
        {
            try
            {
                db.Entry(teacher).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee    
        public Teacher GetTeacherData(int id)
        {
            try
            {
                Teacher teacher = db.Teacher.Find(id);
                return teacher;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular employee    
        public void DeleteTeacher(int id)
        {
            try
            {
                Teacher emp = db.Teacher.Find(id);
                db.Teacher.Remove(emp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
