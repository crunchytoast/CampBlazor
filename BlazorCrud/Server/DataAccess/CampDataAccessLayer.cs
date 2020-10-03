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
    public class CampDataAccessLayer: ICamp
    {
        private CampDbContext db;

        public CampDataAccessLayer(CampDbContext ctx)
        {
            db = ctx;
        }

        //To Get all Camps details   
        public IEnumerable<Camp> GetAllCamps()
        {
            try
            {
                return db.Camp.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new Camp record     
        public void AddCamp(Camp camp)
        {
            try
            {
                db.Camp.Add(camp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee    
        public void UpdateCamp(Camp Camp)
        {
            try
            {
                db.Entry(Camp).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee    
        public Camp GetCampData(int id)
        {
            try
            {
                Camp Camp = db.Camp.Find(id);
                return Camp;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular employee    
        public void DeleteCamp(int id)
        {
            try
            {
                Camp cmp = db.Camp.Find(id);
                db.Camp.Remove(cmp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
