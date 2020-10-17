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
    public class ClassDataAccessLayer : IClass
    {
        private CampDbContext db;

        public ClassDataAccessLayer(CampDbContext ctx)
        {
            db = ctx;
        }

        //To Get all Class details   
        public IEnumerable<Class> GetAllClasses()
        {
            try
            {
                return db.Class.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new Class record     
        public void AddClass(Class Class)
        {
            try
            {
                db.Class.Add(Class);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Class    
        public void UpdateClass(Class Class)
        {
            try
            {
                db.Entry(Class).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Class    
        public Class GetClassData(int id)
        {
            try
            {
                Class Class = db.Class.Find(id);
                return Class;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Class    
        public void DeleteClass(int id)
        {
            try
            {
                Class emp = db.Class.Find(id);
                db.Class.Remove(emp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
