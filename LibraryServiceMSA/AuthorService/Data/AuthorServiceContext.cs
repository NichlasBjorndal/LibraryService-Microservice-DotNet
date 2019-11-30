using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AuthorService.Models
{
    public class AuthorServiceContext : DbContext
    {
        public AuthorServiceContext (DbContextOptions<AuthorServiceContext> options)
            : base(options)
        {
        }

        public DbSet<AuthorService.Models.Author> Author { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var author1 = new Author
            {
                Id = 1,
                FirstName = "Edger Allan",
                LastName = "Poe"
            };

            var author2 = new Author
            {
                Id = 2,
                FirstName = "Thomas",
                LastName = "Edison"
            };

            var author3 = new Author
            {
                Id = 3,
                FirstName = "H.C",
                LastName = "Andersen"
            };

            modelBuilder.Entity<Author>().HasData(
                author1, author2, author3
            );
        }
    }
}
