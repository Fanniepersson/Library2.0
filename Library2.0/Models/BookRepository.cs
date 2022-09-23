using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _libraryContext;

        public BookRepository(LibraryDbContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        public IEnumerable<Book> GetAllBooks
        {
            get
            {
                return _libraryContext.Books.ToList();
            }
        }
    }
}
