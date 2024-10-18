using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moldovan_Alex_Cristian_Lab3.Models;

namespace Moldovan_Alex_Cristian_Lab3.Data
{
    public class Moldovan_Alex_Cristian_Lab3Context : DbContext
    {
        public Moldovan_Alex_Cristian_Lab3Context (DbContextOptions<Moldovan_Alex_Cristian_Lab3Context> options)
            : base(options)
        {
        }

        public DbSet<Moldovan_Alex_Cristian_Lab3.Models.Book> Book { get; set; } = default!;
        public DbSet<Moldovan_Alex_Cristian_Lab3.Models.Publisher> Publisher { get; set; } = default!;
    }
}
