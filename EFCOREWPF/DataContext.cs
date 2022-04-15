using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCOREWPF.Models;
using Microsoft.EntityFrameworkCore;
namespace EFCOREWPF
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFCore;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasMany(y => y.Books).WithOne(y => y.Category);

            modelBuilder.Entity<Book>().HasMany(r => r.RelBookPublishers).WithOne(t => t.Book);
            modelBuilder.Entity<Publisher>().HasMany(r => r.RelBookPublishers).WithOne(t => t.Publisher);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
