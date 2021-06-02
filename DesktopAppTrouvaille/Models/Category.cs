﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public int ProductCounter { get; set; }
        public ICollection<Guid> ProductIds { get; set; } = new List<Guid>();

        public Category() { }

        // Copy Contructor:
        public Category(Category other)
        {
            CategoryId = other.CategoryId;
            Name = other.Name;
            ProductCounter = other.ProductCounter;
            other.ProductIds = ProductIds.ToList<Guid>();
        }

        public override bool Equals(object other)
        {
            Category cat = (Category)other;
            if(CategoryId == cat.CategoryId)
            {
                return true;
            }
            return false;
        }

    }
}
