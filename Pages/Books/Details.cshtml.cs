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
    public class DetailsModel : PageModel
    {
        private readonly Moldovan_Alex_Cristian_Lab3.Data.Moldovan_Alex_Cristian_Lab3Context _context;

        public DetailsModel(Moldovan_Alex_Cristian_Lab3.Data.Moldovan_Alex_Cristian_Lab3Context context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }
            return Page();
        }
    }
}
