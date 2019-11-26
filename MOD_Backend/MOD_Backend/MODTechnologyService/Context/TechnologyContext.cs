using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODTechnologyService.Context;
using MODTechnologyService.Models;

namespace MODTechnologyService.Context
{
    public class TechnologyContext :DbContext
    {
        public TechnologyContext(DbContextOptions<TechnologyContext> options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Technology> Technologys { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Payment> Payments { get; set; }

    }
}
