using MODAuthenticateService.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODAuthenticateService.Models;

namespace MODAuthenticateService.Repositories
{
    public class LoginRepository: ILoginRepository
    {
        private readonly LoginContext _context;
        public LoginRepository(LoginContext context)
        {
            _context = context;
        }
        public Mentor MentorLogin(string M_EmailId , string M_Password)
        {
            try
            {
                return _context.Mentors.SingleOrDefault(data => data.Mentor_EmailId == M_EmailId && data.Mentor_Password == M_Password && data.Mentor_Active == true);
                //if (obj != null)
                //    return true;
                //else
                //    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public User UserLogin(string U_EmailId , string U_Password)
        {
            try
            {
                return _context.Users.SingleOrDefault(data => data.User_Email == U_EmailId && data.User_Password == U_Password && data.User_Active == true);
                //if (obj != null)
                //    return true;
                //else
                //    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
