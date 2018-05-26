using System;
using Microsoft.EntityFrameworkCore;
using PControl.DomainModel.CalcBalance;

namespace PControl.DAL.EF
{
    internal class ApplicationContext: DbContext
    {
        private readonly string _connectionString;
        public DbSet<Product> Products { get; set; }
        public DbSet<Balance> Balanses { get; set; }
        public DbSet<Document> Documents { get; set; }

        public ApplicationContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Balance>().HasKey(b => new {b.Date, b.Product});
        }
    }
}