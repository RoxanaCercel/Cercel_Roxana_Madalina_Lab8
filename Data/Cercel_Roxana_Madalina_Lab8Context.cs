using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cercel_Roxana_Madalina_Lab8.Models;

namespace Cercel_Roxana_Madalina_Lab8.Data
{
    public class Cercel_Roxana_Madalina_Lab8Context : DbContext
    {
        public Cercel_Roxana_Madalina_Lab8Context (DbContextOptions<Cercel_Roxana_Madalina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cercel_Roxana_Madalina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Cercel_Roxana_Madalina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cercel_Roxana_Madalina_Lab8.Models.Category> Category { get; set; }
    }
}
