using UKEA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UKEA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }  
        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<FurnitureCategory> FurnitureCategories { get; set; }


    }
}
