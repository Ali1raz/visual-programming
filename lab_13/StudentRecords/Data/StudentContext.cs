using Microsoft.EntityFrameworkCore;
using StudentRecords.Models;

namespace StudentRecords.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } = null!;
    }
}