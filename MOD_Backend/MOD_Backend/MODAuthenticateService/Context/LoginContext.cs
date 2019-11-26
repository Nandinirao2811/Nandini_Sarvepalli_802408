using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODAuthenticateService.Models;
using MODAuthenticateService.Context;
using Microsoft.EntityFrameworkCore;

namespace MODAuthenticateService.Context
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Technology> Technologys { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Payment> Payments { get; set; }


    }
}
