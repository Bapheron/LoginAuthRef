﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAuthRef.Models
{
    public class MyTestDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\Local;Initial Catalog=LogRegRefDb;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData
                 (
                      new Role
                      {
                          Id = 1,
                          Name = "Administrator",
                          AccessRights = "FullAccess"
                      },
                      new Role
                      {
                          Id = 2,
                          Name = "User",
                          AccessRights = "LimitedAccess"
                      }
                 );

            modelBuilder.Entity<Models.User>().HasData
            (
                new User
                {
                    Id = 1,
                    Login = "admin",
                    Password = "1",
                    RegistrationDate = DateOnly.FromDateTime(DateTime.Now),
                    Surname = "Doe",
                    Name = "John",
                    Phone = "+9238",
                    RoleId = 1
                },
                 new User
                 {
                     Id = 2,
                     Login = "user1",
                     Password = "1",
                     RegistrationDate = DateOnly.FromDateTime(DateTime.Now),
                     Surname = "Jhons",
                     Name = "Jassy",
                     Phone = "+27391",
                     RoleId = 2
                 }
            );
        }
    }
}
