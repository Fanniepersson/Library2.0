﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks { get; }
    }
}
