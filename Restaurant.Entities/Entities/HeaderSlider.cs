using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Restaurant.Entities
{
    public class HeaderSlider
    {
        [Key]
        public int Id { get; set; }
        [StringLength(300)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
    }
}
