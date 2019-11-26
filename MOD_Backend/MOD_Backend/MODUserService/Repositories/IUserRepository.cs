using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODUserService.Context;
using MODUserService.Models;


namespace MODUserService.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(int id);

        void AddUser(User item);
        void DeleteUser(int id);
        void UpdateUserPassword(string Useremail, string Userpassword);

        void BlockUser(int id);
        List<Mentor> GetMentorSearch(string skill, string fromTimeslot, string toTimeslot);
    }

}
