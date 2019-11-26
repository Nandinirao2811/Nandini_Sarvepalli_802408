using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MODAuthenticateService.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
    
        [Required]
        public string User_Name { get; set; }
        [Required]
        public string User_Email { get; set; }
        
        public string User_Password { get; set; }
        [Required]
        public long User_MobileNo { get; set; }

        public bool? User_Active { get; set; }
    }
}
