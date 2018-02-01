using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Entities
{
    public class MenuCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public List<MenuItem> MenuItems { get; set; }
    }
}
