using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.Models
{
    public class LibraryLoan
    {
        [Key]
        public int LoanId { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime DayOfLoan { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime LastDayToReturn { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime DayOfReturn { get; set; }
        public bool IsReturned { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
