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

            optionsBuilder.UseSqlServer("Server=tcp:sqlazureserver1000.database.windows.net,1433;Initial Catalog=DenemeDB;Persist Security Info=False;User ID=codebooksadmin;Password=1327_Deneme;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Makale> Makales { get; set; }

    }
}
