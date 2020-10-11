using BlazorCrud.Server.Interfaces;
using BlazorCrud.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorCrud.Server.DataAccess
{
    public class StudentDataAccessLayer: IStudent
    {
        private CampDbContext db;

        public StudentDataAccessLayer(CampDbContext ctx)
        {
            db = ctx;
        }

        //To Get all Student details   
        public IEnumerable<Student> GetAllStudents()
        {
            try
            {
                return db.Student.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new Student record     
        public void AddStudent(Student Student)
        {
            try
            {
                db.Student.Add(Student);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Student    
        public void UpdateStudent(Student Student)
        {
            try
            {
                db.Entry(Student).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Student    
        public Student GetStudentData(int id)
        {
            try
            {
                Student Student = db.Student.Find(id);
                return Student;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Student    
        public void DeleteStudent(int id)
        {
            try
            {
                Student Student = db.Student.Find(id);
                db.Student.Remove(Student);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
