using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODUserService.Models;
using MODUserService.Context;

namespace MODUserService.Repositories
{
    public class MentorRepository : IMentorRepository
    {
        private readonly UserContext _context;
        public MentorRepository(UserContext context)
        {
            _context = context;
        }
        public void AddMentor(Mentor item)
        {
            try
            {
                _context.Mentors.Add(item);
                _context.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void BlockMentor(int id)
        {
            try
            {
                var item = _context.Mentors.Find(id);
                item.Mentor_Active = !(item.Mentor_Active);
                _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void DeleteMentor(int id)
        {
            try
            {
                var item = _context.Mentors.Find(id);
                _context.Mentors.Remove(item);
                _context.SaveChanges();
            }
            
            catch (Exception)
            {
                throw;
            }
        }

        public List<Mentor> GetAllMentors()
        {
            try
            {
                return _context.Mentors.ToList();
            }
            catch (Exception)
            {
                throw;
            }


        }

        public Mentor GetMentorById (int Id)
        {
            try
            {
                return _context.Mentors.Find(Id);
            }
            
             catch (Exception)
            {
                throw;
            }
        }

     
        public void UpdateMentorPassword(string Mentoremail, string Mentorpassword)
        {
            try
            {
                var item = _context.Mentors.SingleOrDefault(i => i.Mentor_EmailId == Mentoremail);
                item.Mentor_Password = Mentorpassword;

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
