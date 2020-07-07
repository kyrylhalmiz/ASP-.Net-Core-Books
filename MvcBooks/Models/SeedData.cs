using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcBooks.Data;

namespace MvcBooks.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBookContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBookContext>>()))
            {
                // Look for any books.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "The Shining",
                        Author = "Stephen King",
                        ReleaseDate = DateTime.Parse("1977-28-1"),
                        Price = 7.99M
                    },

                    new Book
                    {
                        Title = "Dr. Sleep",
                        Author = "Stephen King",
                        ReleaseDate = DateTime.Parse("2012-14-8"),
                        Price = 8.5M
                    },

                    new Book
                    {
                        Title = "Eragon",
                        Author = "Christopher Paolini",
                        ReleaseDate = DateTime.Parse("2010-23-2"),
                        Price = 17M
                    },

                    new Book
                    {
                        Title = "Lord Of The Rings",
                        Author = "J. R. R. Tolkien",
                        ReleaseDate = DateTime.Parse("1935-12-5"),
                        Price = 14M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
