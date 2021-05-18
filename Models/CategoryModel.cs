﻿using DesktopAppTrouvaille.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class CategoryModel
    {
        public Guid CategoryId { get; set; }

        public string Name { get; set; }

        public int ProductCounter { get; set; }

        public virtual ICollection<Guid> Products { get; set; }
    }
}
