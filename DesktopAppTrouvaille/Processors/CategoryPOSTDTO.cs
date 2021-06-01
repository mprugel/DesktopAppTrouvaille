using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Processors
{
    public class CategoryPOSTDTO
    {
        public string Name { get; set; }

        public CategoryPOSTDTO(Category category)
        {
            Name = category.Name;
        }
    }
}
