using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moldovan_Alex_Cristian_Lab3.Data;
using Moldovan_Alex_Cristian_Lab3.Models;

namespace Moldovan_Alex_Cristian_Lab3.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Moldovan_Alex_Cristian_Lab3.Data.Moldovan_Alex_Cristian_Lab3Context _context;

        public IndexModel(Moldovan_Alex_Cristian_Lab3.Data.Moldovan_Alex_Cristian_Lab3Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
            .Include(b => b.Publisher)
            .ToListAsync();
        }
    }
}
