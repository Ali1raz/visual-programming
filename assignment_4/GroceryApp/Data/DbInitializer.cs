using GroceryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize()
        {
            using var db = new AppDbContext();
            db.Database.EnsureCreated();

            if (!db.GroceryItems.Any())
            {
                db.GroceryItems.AddRange(
                    new GroceryItem { Name = "Milk", Quantity = 2, Category = "Dairy" },
                    new GroceryItem { Name = "Apples", Quantity = 5, Category = "Fruits" },
                    new GroceryItem { Name = "Bread", Quantity = 1, Category = "Bakery" },
                    new GroceryItem { Name= "Eggs", Quantity = 12, Category = "Dairy" },
                    new GroceryItem { Name = "Chicken", Quantity = 1, Category = "Meat" },
                    new GroceryItem { Name = "Rice", Quantity = 2, Category = "Grains" },
                    new GroceryItem { Name = "Pasta", Quantity = 3, Category = "Grains" },
                    new GroceryItem { Name = "Tomatoes", Quantity = 4, Category = "Vegetables" },
                    new GroceryItem { Name = "Cheese", Quantity = 1, Category = "Dairy" },
                    new GroceryItem { Name = "Yogurt", Quantity = 6, Category = "Dairy" },
                    new GroceryItem { Name = "Bananas", Quantity = 6, Category = "Fruits" }
                );

                db.SaveChanges();
            }
        }
    }
}
