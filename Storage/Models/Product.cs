using System;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{

    public class Product
    {
        [Key]
        public int id { get; set; }


        [MaxLength(24)]
        public string Name { get; set; }

        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public string Category { get; set; }
        [MaxLength(24)]
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }
}
