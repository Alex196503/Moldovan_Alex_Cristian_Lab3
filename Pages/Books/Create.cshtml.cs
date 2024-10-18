using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Moldovan_Alex_Cristian_Lab3.Data;
using Moldovan_Alex_Cristian_Lab3.Models;

namespace Moldovan_Alex_Cristian_Lab3.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Moldovan_Alex_Cristian_Lab3.Data.Moldovan_Alex_Cristian_Lab3Context _context;

        public CreateModel(Moldovan_Alex_Cristian_Lab3.Data.Moldovan_Alex_Cristian_Lab3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID",
"PublisherName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
