﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    public class Material
    {
        public Guid Id { get; set; }    
        public string Name { get; set; } 
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public DateTime DatePurchase { get; set; }
        
        private static List<Material> MaterialList = new List<Material>();

        public Material(string Name, string Description, decimal Price)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            DatePurchase = DateTime.Now;
            MaterialList.Add(this);
        }

        public static void MaterialPurchased()
        {
            foreach(Material material in MaterialList)
            {
                Console.WriteLine($"{material.Name} purchased at {material.DatePurchase}\n£{material.Price} for {material.Description}");
            }
        }
    }
}