using GroceryApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<GroceryItem> GroceryItems => Set<GroceryItem>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "grocery.db");
            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}
