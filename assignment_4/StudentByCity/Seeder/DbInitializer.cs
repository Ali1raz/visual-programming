using assignment_4.Data;
using assignment_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4.Seeder
{
    public static class DbInitializer
    {
        public static void Initialize()
        {
            using var db = new AppDbContext();
            db.Database.EnsureCreated();

            if (!db.Students.Any())
            {
                db.Students.AddRange(
                    new Student { FullName = "Ali Raza", City = "Burewala" },
                    new Student { FullName = "Ahmar", City = "Vehari" },
                    new Student { FullName = "Naveed", City = "Multan" },
                    new Student { FullName = "Asad", City = "Burewala" },
                    new Student { FullName = "Vehari", City = "Waseem" }

                );
                db.SaveChanges();
            }
        }
    }
}
