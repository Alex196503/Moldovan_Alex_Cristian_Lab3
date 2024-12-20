﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moldovan_Alex_Cristian_Lab3.Data;
using Moldovan_Alex_Cristian_Lab3.Models;

namespace Moldovan_Alex_Cristian_Lab3.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Moldovan_Alex_Cristian_Lab3.Data.Moldovan_Alex_Cristian_Lab3Context _context;

        public IndexModel(Moldovan_Alex_Cristian_Lab3.Data.Moldovan_Alex_Cristian_Lab3Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
