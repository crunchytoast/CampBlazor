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
    public class UDateDataAccessLayer : IUDate
    {
        private CampDbContext db;

        public UDateDataAccessLayer(CampDbContext ctx)
        {
            db = ctx;
        }

        //To Get all UDates details   
        public IEnumerable<UDate> GetAllUDates()
        {
            try
            {
                return db.UDate.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new UDate record     
        public void AddUDate(UDate UDate)
        {
            try
            {
                db.UDate.Add(UDate);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar UDate    
        public void UpdateUDate(UDate UDate)
        {
            try
            {
                db.Entry(UDate).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular UDate    
        public UDate GetUDateData(int id)
        {
            try
            {
                UDate UDate = db.UDate.Find(id);
                return UDate;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular UDate    
        public void DeleteUDate(int id)
        {
            try
            {
                UDate emp = db.UDate.Find(id);
                db.UDate.Remove(emp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
