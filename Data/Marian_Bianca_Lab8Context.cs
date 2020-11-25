using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marian_Bianca_Lab8.Models;

namespace Marian_Bianca_Lab8.Data
{
    public class Marian_Bianca_Lab8Context : DbContext
    {
        public Marian_Bianca_Lab8Context (DbContextOptions<Marian_Bianca_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Marian_Bianca_Lab8.Models.Book> Book { get; set; }

        public DbSet<Marian_Bianca_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Marian_Bianca_Lab8.Models.Category> Category { get; set; }
    }
}
