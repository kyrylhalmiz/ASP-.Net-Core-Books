using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBooks.Models
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        [StringLength(50, MinimumLength = 2)]
        public string Author { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(100, 2)")]
        public decimal Price { get; set; }
    }
}
