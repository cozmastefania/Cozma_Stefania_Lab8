using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cozma_Stefania_Lab8.Models;

namespace Cozma_Stefania_Lab8.Data
{
    public class Cozma_Stefania_Lab8Context : DbContext
    {
        public Cozma_Stefania_Lab8Context (DbContextOptions<Cozma_Stefania_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cozma_Stefania_Lab8.Models.Book> Book { get; set; }

        public DbSet<Cozma_Stefania_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cozma_Stefania_Lab8.Models.Category> Category { get; set; }
    }
}
