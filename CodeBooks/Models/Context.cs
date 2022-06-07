using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBooks.Models
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Sedat; database=CodeBooksDB; integrated security =true;");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Makale> Makales { get; set; }

    }
}
