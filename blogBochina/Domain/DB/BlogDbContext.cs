﻿using blogBochina.Model.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogBochina.Domain.DB
{
    public class BlogDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options) {
            Database.EnsureCreated();
        }

        ///пользователи
        public override DbSet<User> Users { get; set; }

        ///сотрудники
        public DbSet<Employee> Employee { get; private set; }

        ///пост блога
        public DbSet<BlogPost> BlogPosts { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(x =>
            {
                x.HasOne(y => y.Employee)
                .WithOne()
                .HasForeignKey<User>("EmployeeId")
                .IsRequired(true);
                x.HasIndex("EmployeeId").IsUnique(true);
            });
            #region Employee
            modelBuilder.Entity<Employee>(b =>
            {
                b.ToTable("Employees");
                EntityId(b);
                b.Property(x => x.Surname)
                .HasColumnName("Surname").IsRequired();
                b.Property(x => x.Address)
                .HasColumnName("Address");
                b.Ignore(x => x.FullName);

            });
            #endregion

            #region BlogPost
            modelBuilder.Entity<BlogPost>(b =>
            {
                b.ToTable("BlogPosts");
                EntityId(b);
                b.Property(x => x.Created).HasColumnName("Created")
                .IsRequired();
                b.Property(x => x.Title).HasColumnName("Date")
                .IsRequired();
                b.HasOne(x => x.Owner).WithMany().IsRequired();
            });
            #endregion

        }

        private static void EntityId<TEntity>(EntityTypeBuilder<TEntity> builder)
            where TEntity : Entity
        {
            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            builder.HasKey(x => x.Id).HasAnnotation("Npgsql:Serial", true);
        }
    }
}
