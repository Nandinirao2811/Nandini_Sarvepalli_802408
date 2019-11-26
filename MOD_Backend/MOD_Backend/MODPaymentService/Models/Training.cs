using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MODPaymentService.Models
{
    public class Training
    {
        [Key]
        public int Training_Id { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        [ForeignKey("Mentor")]
        public int Mentor_Id { get; set; }
        [ForeignKey("Technology")]
        public int Skill_Id { get; set; }
        [Required]
        public DateTime Training_StartDate { get; set; }
        [Required]
        public DateTime Training_EndDate { get; set; }
        [Required]
        public string Training_TimeSlot { get; set; }
        [Required]
        public string Training_Status { get; set; }
        public string Training_Progress { get; set; }
        public int Training_Rating { get; set; }

        public User User  {get; set;}
        public Mentor Mentor { get; set; }
        public Technology Technology { get; set; }
//        public IEnumerable<Payment> Payments { get; set; }

    }
}
