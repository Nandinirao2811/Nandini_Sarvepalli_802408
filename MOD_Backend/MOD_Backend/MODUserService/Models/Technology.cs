using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MODUserService.Models
{
    public class Technology
    {
        [Key]
        public int Skill_Id { get; set; }
        public string Skill_Name { get; set; }
        
        public string Skill_TOC { get; set; }

        public double? Skill_Fees { get; set; }
        public string Skill_Duration { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
    }
}
