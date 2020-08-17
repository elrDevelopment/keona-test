using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication.DataAccess
{
    public partial class keonaContext : DbContext
    {
        public keonaContext()
        {
        }

        public keonaContext(DbContextOptions<keonaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<JsonReturn> JsonReturn { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:erickdemo.database.windows.net,1433;Initial Catalog=keona;Persist Security Info=False;User ID=erick;Password=Rooster12!@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JsonReturn>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("JsonReturn_pk")
                    .IsClustered(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("Order_pk")
                    .IsClustered(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .HasName("Person_pk")
                    .IsClustered(false);

                entity.Property(e => e.NameFirst).HasMaxLength(25);

                entity.Property(e => e.NameLast).HasMaxLength(25);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
