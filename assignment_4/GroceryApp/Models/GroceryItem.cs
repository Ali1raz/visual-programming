﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Models
{
    public class GroceryItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Quantity { get; set; }
        public string Category { get; set; } = "";
    }
}
