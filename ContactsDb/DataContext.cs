using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace ContactsDb
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base (options)
        {

        }
        public DbSet<User> Users {get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Contact>().ToTable("Contact");

        }
    }
}