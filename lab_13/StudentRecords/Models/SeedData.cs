using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentRecords.Data;
using System;
using System.Linq;

namespace StudentRecords.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new StudentContext(
                serviceProvider.GetRequiredService<DbContextOptions<StudentContext>>());

            // Check if any students exist
            if (context.Students.Any())
            {
                return; // DB has been seeded
            }            // Seed data
            context.Students.AddRange(
                new Student { Name = "Alice Smith", RollNumber = "CS101", GPA = 3.85 },
                new Student { Name = "Bob Johnson", RollNumber = "CS102", GPA = 3.90 },
                new Student { Name = "Charlie Brown", RollNumber = "CS103", GPA = 3.78 }
            );

            context.SaveChanges();
        }
    }
}