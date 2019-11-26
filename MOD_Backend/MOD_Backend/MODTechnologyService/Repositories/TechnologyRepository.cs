using MODTechnologyService.Context;
using MODTechnologyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MODTechnologyService.Repositories
{
    public class TechnologyRepository : ITechnologyRepository
    {
        private readonly TechnologyContext _context;

        public TechnologyRepository(TechnologyContext context)
        {
            _context = context;
        }

        public void AddTechnology(Technology item)
        {
            try
            {
                _context.Technologys.Add(item);
                _context.SaveChanges();
            }
            
               catch (Exception)
            {
                throw;
            }
        }
        
        public void DeleteTechnology(int id)
        {
            try
            {
                var item = _context.Technologys.Find(id);
                _context.Technologys.Remove(item);
                _context.SaveChanges();
            }      
            catch (Exception)
            {
                throw;
            }
        }

        public List<Technology> GetAllTechnology()
        {
            try
            {
                return _context.Technologys.ToList();
            }
           
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateTechnology(Technology item)
        {
            try
            {
                _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
           
             catch (Exception)
            {
                throw;
            }
        }
    }
}
