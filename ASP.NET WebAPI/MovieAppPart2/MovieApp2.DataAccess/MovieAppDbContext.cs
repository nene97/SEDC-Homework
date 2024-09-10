using Microsoft.EntityFrameworkCore;
using MovieApp2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.DataAccess
{
    public class MovieAppDbContext :DbContext
    {
        public MovieAppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>()
                .Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Movie>()
                   .Property(x =>x.Description)
                   .IsRequired()
                   .HasMaxLength(250);

            modelBuilder.Entity<Movie>()
                 .Property(x => x.Year)
                 .IsRequired();

            modelBuilder.Entity<Movie>()
                .Property(x => x.Genre)
                .IsRequired();


            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);

                entity.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength (50);

                entity.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(50);

                entity.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(70);

                entity.Property(u => u.Role)
                .IsRequired();

                entity.Property(u => u.FavouriteGenre)
                .IsRequired();

                entity.HasMany(u => u.MovieList)
                .WithMany(m => m.Users);
            });
        }

        


    }
}
