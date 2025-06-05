using assignment_4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        private const string DbPath = "students.db";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }
    }
}
