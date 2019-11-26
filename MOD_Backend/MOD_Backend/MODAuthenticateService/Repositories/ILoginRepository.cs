using MODAuthenticateService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MODAuthenticateService.Repositories
{
   public interface ILoginRepository
    {
        User UserLogin(string User_EmailId, string User_Password);
        Mentor MentorLogin(string Mentor_EmailId, string Mentor_Password);
    }
}
