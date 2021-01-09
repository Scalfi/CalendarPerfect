using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarPerfect.Models.Database
{
    public class PostgresContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerSickness> CustomerSicknesses { get; set; }
        public DbSet<Medicine>  Medicines { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<SendEmail> SendEmails { get; set; }
        public DbSet<Sickness> Sicknesses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
