using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MODTrainingService.Models
{
    public class Mentor
    {
        [Key]
        public int Mentor_Id { get; set; }
       
        [Required]
        public string Mentor_FirstName { get; set; }
        
        public string Mentor_LastName { get; set; }
        public string Mentor_University { get; set; }
        [Required]
        public long Mentor_MobileNo { get; set; }
        public string Mentor_LinkedInUrl { get; set; }
        public int Mentor_YearsOfExperience { get; set; }

        public string Mentor_FromTimeSlot { get; set; }
        public string Mentor_ToTimeSlot { get; set; }
        public bool Mentor_Avaliability { get; set; }
        public bool? Mentor_Active { get; set; }
        public string Mentor_PrimarySkill { get; set; }
        [Required]
        public string Mentor_EmailId { get; set; }
        [Required]
        public string Mentor_Password { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> Payments { get; set; }



    }
}
