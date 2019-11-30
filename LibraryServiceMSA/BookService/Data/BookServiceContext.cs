using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookService.Models
{
    public class BookServiceContext : DbContext
    {
        public BookServiceContext (DbContextOptions<BookServiceContext> options)
            : base(options)
        {
        }

        public DbSet<BookService.Models.Book> Book { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var book1 = new Book
            {
                Id = 1,
                ISBN = "1234",
                Title = "Book A",
                AuthorId = 1
            };

            var book2 = new Book
            {
                Id = 2,
                ISBN = "1234",
                Title = "Book B",
                AuthorId = 2
            };

            var book3 = new Book
            {
                Id = 3,
                ISBN = "1234",
                Title = "Book Z",
                AuthorId = 3
            };

            modelBuilder.Entity<Book>(b =>
            {
                b.HasData(
                    book1, book2, book3
                );
            });
        }
    }
}
