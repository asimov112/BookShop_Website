using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore_Website.Models;

namespace BookStore_Website.Data
{
    public class BookStore_WebsiteContext : DbContext
    {
        public BookStore_WebsiteContext (DbContextOptions<BookStore_WebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<BookStore_Website.Models.Book> Book { get; set; } = default!;
    }
}
