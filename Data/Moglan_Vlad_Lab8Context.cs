using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moglan_Vlad_Lab8.Models;

namespace Moglan_Vlad_Lab8.Data
{
    public class Moglan_Vlad_Lab8Context : DbContext
    {
        public Moglan_Vlad_Lab8Context (DbContextOptions<Moglan_Vlad_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Moglan_Vlad_Lab8.Models.Book> Book { get; set; }

        public DbSet<Moglan_Vlad_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Moglan_Vlad_Lab8.Models.Category> Category { get; set; }
    }
}
