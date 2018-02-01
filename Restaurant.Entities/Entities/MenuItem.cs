using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Entities
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
 
        public int Price { get; set; }
        public int OldPrice { get; set; }
        [StringLength(250)]
        public string ImageUrl { get; set; }

        public int CateId { get; set; }

        [ForeignKey("CateId")]
        public MenuCategory MenuCategory { get; set; }
    }
}
