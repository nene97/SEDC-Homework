using LibraryApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.DataAccess
{
    public class LibraryAppDbContext : DbContext
    {
        public LibraryAppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .Property(x => x.Title)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Book>()
                .Property(x => x.Description)
                .HasMaxLength(500);

            modelBuilder.Entity<Book>()
                .Property(x => x.Genre)
                .IsRequired();

            modelBuilder.Entity<Book>()
                .HasOne(x => x.AuthorUser)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.AuthorUserId);


            modelBuilder.Entity<Author>()
                .Property(x => x.FirstName)
                .HasMaxLength(50)
                .IsRequired();


            modelBuilder.Entity<Author>()
                .Property(x => x.LastName)
                .HasMaxLength(50)
                .IsRequired();

            
            //LibraryAppDb

        }
    }
}
