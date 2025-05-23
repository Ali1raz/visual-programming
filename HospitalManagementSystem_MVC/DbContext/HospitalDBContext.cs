using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem_MVC.Models;

namespace HospitalManagementSystem.DbContext
{
    public class HospitalDBContext : DbContext
    {
        public HospitalDBContext(DbContextOptions<HospitalDBContext> options) : base(options) {}

        public DbSet<Patient> Patients { get; set; } = null!;
        public DbSet<Doctor> Doctors { get; set; } = null!;
        public DbSet<Appointment> Appointments { get; set; } = null!;
    }
}