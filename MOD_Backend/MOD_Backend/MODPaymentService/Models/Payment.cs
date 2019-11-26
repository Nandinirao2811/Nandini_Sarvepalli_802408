using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace MODPaymentService.Models
{
    public class Payment
    {
        [Key]
        public int Payment_Id { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        [ForeignKey("Mentor")]
        public int Mentor_Id { get; set; }
        /*[ForeignKey("Training")]
        public int Training_Id { get; set; }*/

        public double Payment_Amount { get; set; }

        public string Skill_Name { get; set; }

        public double Mentor_Amount { get; set; }
        public User User { get; set; }
        public Mentor Mentor { get; set; }
        // public Training Training { get; set; }

    }
}
