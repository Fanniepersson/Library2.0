using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Firstname")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Lastname")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "City")]
        [StringLength(100)]
        public string City { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Zipcode")]
        [StringLength(10, MinimumLength = 5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        
        public List<LibraryLoan> LibraryLoans { get; set; }
    }
}
