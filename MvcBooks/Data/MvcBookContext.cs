using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcBooks.Models;

namespace MvcBooks.Data
{
    public class MvcBookContext:DbContext
    {
        public MvcBookContext(DbContextOptions<MvcBookContext> options)
    : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}
