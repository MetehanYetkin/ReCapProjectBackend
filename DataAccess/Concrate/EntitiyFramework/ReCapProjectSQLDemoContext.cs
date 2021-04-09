using Core.Entities.Concrate;

using Entitiy.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EntitiyFramework
{
   public class ReCapProjectSQLDemoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDb;Database=ReCapProjectSQLDemo;Trusted_Connection=True");

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Userss { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentalss { get; set; }
        public DbSet<CarImage> CarImagess { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
