using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using system_bdt.Models.Entities;

namespace system_bdt.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("PostgresConnection")
        {
        }

        public DbSet<Account> Accounts { get; set; } 
        public DbSet<Enterprise> Enterprises { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestDegree> RequestDegrees { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<RequestPersonal> RequestPersonals { get; set; }
    }
}