using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookStore_Website.Data;
using BookStore_Website.Models;

namespace BookStore_Website.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookStore_Website.Data.BookStore_WebsiteContext _context;

        public IndexModel(BookStore_Website.Data.BookStore_WebsiteContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
