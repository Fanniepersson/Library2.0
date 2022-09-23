using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Langugage { get; set; }
        [Required]
        public string ReleaseYear { get; set; }
        [Required]
        public int AmountOfThisBook { get; set; }
        public bool Avaliable { get; set; }
        public string ImageThmbnailUrl { get; set; }
        
        public List<LibraryLoan> LibraryLoans { get; set; }
    }
}
