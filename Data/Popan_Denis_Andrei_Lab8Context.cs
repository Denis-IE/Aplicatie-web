using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Popan_Denis_Andrei_Lab8.Models;

namespace Popan_Denis_Andrei_Lab8.Data
{
    public class Popan_Denis_Andrei_Lab8Context : DbContext
    {
        public Popan_Denis_Andrei_Lab8Context (DbContextOptions<Popan_Denis_Andrei_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Popan_Denis_Andrei_Lab8.Models.Book> Book { get; set; }

        public DbSet<Popan_Denis_Andrei_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Popan_Denis_Andrei_Lab8.Models.Category> Category { get; set; }
    }
}
