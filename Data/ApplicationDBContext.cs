using Microsoft.EntityFrameworkCore;
using mvc_postgresql.Models;
using System.Collections.Generic;
using mvc_postgresql.Models;

namespace mvc_postgresql.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
    }
}
