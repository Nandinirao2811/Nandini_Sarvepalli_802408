using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODUserService.Context;
using MODUserService.Models;

namespace MODUserService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public void AddUser(User item)
        {
            try
            {
                _context.Users.Add(item);
                _context.SaveChanges();
            }
           
              catch (Exception)
            {
                throw;
            }
        }

        public void BlockUser(int id)
        {
            try
            {
                var item = _context.Users.Find(id);
                item.User_Active = !(item.User_Active);
                _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
           
              catch (Exception)
            {
                throw;
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                var item = _context.Users.Find(id);
                _context.Users.Remove(item);
                _context.SaveChanges();
            }
           
               catch (Exception)
            {
                throw;
            }
        }

        public List<User> GetAllUsers()
        {
            try
            {
                return _context.Users.ToList();
            }
           
               catch (Exception)
            {
                throw;
            }
        }

        public List<Mentor> GetMentorSearch(string skill, string fromTimeslot, string toTimeslot)
        {
            try
            {
                return (from obj in _context.Mentors
                        where obj.Mentor_PrimarySkill == skill &&
                              obj.Mentor_FromTimeSlot == fromTimeslot &&
                                obj.Mentor_ToTimeSlot == toTimeslot
                        select obj).ToList();
            }
           
               catch (Exception)
            {
                throw;
            }

        }

        public User GetUserById(int id)
        {
            try
            {
                return _context.Users.Find(id);
            }
           
               catch (Exception)
            {
                throw;
            }
        }

        public void UpdateUserPassword(string Useremail, string Userpassword)
        {
            try
            {
                var item = _context.Users.SingleOrDefault(i => i.User_Email == Useremail);
                item.User_Password = Userpassword;

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
