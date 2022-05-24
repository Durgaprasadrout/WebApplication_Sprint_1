using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Sprint_1.Models
{
    public class Category
    {
        [Key]
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        [ForeignKey("Description")]
        public string Description { get; set; }

        public Product Product { get; set; }
      
    }
}
