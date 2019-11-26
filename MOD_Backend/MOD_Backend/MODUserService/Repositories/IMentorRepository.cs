using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODUserService.Context;
using MODUserService.Models;

namespace MODUserService.Repositories
{
    public interface IMentorRepository
    {
        List<Mentor> GetAllMentors();
        void AddMentor(Mentor item);
        Mentor GetMentorById(int id);
        void UpdateMentorPassword(string Mentoremail, string Mentorpassword);
        void DeleteMentor(int id);
        void BlockMentor(int id);
    }
}
