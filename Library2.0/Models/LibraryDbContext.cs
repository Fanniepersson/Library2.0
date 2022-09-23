using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<LibraryLoan> LibraryLoans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 1,
                Title = "Jag är Zlatan Ibrahimovic: Min historia",
                Author = "Zlatan Ibrahimovic, David Lagercrantz",
                Langugage = "English",
                ReleaseYear = "2019",
                AmountOfThisBook = 5,
                Avaliable = true,
                ImageThmbnailUrl = "\\images\\jag-ar-zlatan-ibrahimovic-min-historia.jpg",
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 2,
                Title = "En bur av guld",
                Author = "Camilla Läckberg",
                Langugage = "Swedish",
                ReleaseYear = "2020",
                AmountOfThisBook = 4,
                ImageThmbnailUrl = "\\images\\en-bur-av-guld.jpg",
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 3,
                Title = "Vingar av silver",
                Author = "Camilla Läckberg",
                Langugage = "Swedish",
                ReleaseYear = "2021",
                AmountOfThisBook = 2,
                ImageThmbnailUrl = "\\images\\vingar-av-silver.jpg",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 4,
                Title = "Gökungen",
                Author = "Camilla Läckberg",
                Langugage = "Swedish",
                ReleaseYear = "2022",
                AmountOfThisBook = 1,
                ImageThmbnailUrl = "\\images\\gokungen.jpg",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 5,
                Title = "Isprinsessan",
                Author = "Camilla Läckberg",
                Langugage = "Swedish",
                ReleaseYear = "2017",
                AmountOfThisBook = 2,
                ImageThmbnailUrl = "\\images\\isprinsessan.jpg",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 6,
                Title = "Lejontämjaren",
                Author = "Camilla Läckberg",
                Langugage = "Swedish",
                ReleaseYear = "2017",
                AmountOfThisBook = 1,
                ImageThmbnailUrl = "\\images\\lejontamjaren.jpg",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 7,
                Title = "Isabella",
                Author = "Isabella Löwengrip",
                Langugage = "Swedish",
                ReleaseYear = "2022",
                AmountOfThisBook = 4,
                ImageThmbnailUrl = "\\images\\isabella.jpg",
            });



            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 1,
                FirstName = "Jay",
                LastName = "Duffy",
                Address = "Prestbury Square",
                City = "New York",
                ZipCode = "223345",
                PhoneNumber = "123456789"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 2,
                FirstName = "Emma",
                LastName = "Madison",
                Address = "Fifth Avenue",
                City = "New York",
                ZipCode = "347363",
                PhoneNumber = "684747382"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 3,
                FirstName = "Cora",
                LastName = "Ashley",
                Address = "Rodeo Drive",
                City = "Beverly Hills",
                ZipCode = "586732",
                PhoneNumber = "094853213"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 4,
                FirstName = "Hayes",
                LastName = "Robinson",
                Address = "Griffin Street",
                City = "Phoenix",
                ZipCode = "850413",
                PhoneNumber = "084231496"
            });


            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LoanId = 1,
                BookId = 1,
                CustomerId = 1,
                DayOfLoan = DateTime.Now,
                LastDayToReturn = DateTime.Now.AddDays(30),
            
            });
            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LoanId = 2,
                BookId = 2,
                CustomerId = 1,
                DayOfLoan = DateTime.Now,
                LastDayToReturn = DateTime.Now.AddDays(30),
            });
            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LoanId = 3,
                BookId = 2,
                CustomerId = 2,
                DayOfLoan = DateTime.Now,
                LastDayToReturn = DateTime.Now.AddDays(30),
            });
            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LoanId = 4,
                BookId = 7,
                CustomerId = 2,
                DayOfLoan = DateTime.Now,
                LastDayToReturn = DateTime.Now.AddDays(30),
            });
            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LoanId = 5,
                BookId = 6,
                CustomerId = 3,
                DayOfLoan = DateTime.Now,
                LastDayToReturn = DateTime.Now.AddDays(30),
            });
            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LoanId = 6,
                BookId = 7,
                CustomerId = 3,
                DayOfLoan = DateTime.Now,
                LastDayToReturn = DateTime.Now.AddDays(30),
            });
            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LoanId = 7,
                BookId = 3,
                CustomerId = 4,
                DayOfLoan = DateTime.Now,
                LastDayToReturn = DateTime.Now.AddDays(30),
            });
            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LoanId = 8,
                BookId = 2,
                CustomerId = 2,
                DayOfLoan = DateTime.Now,
                LastDayToReturn = DateTime.Now.AddDays(30),
            });

        }

    }

}
