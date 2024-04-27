using DataLogic.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public class DefaultContext : DbContext
    {
        public DefaultContext()
        {

        }
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //This is the connection String - Read from the environment variable.
            //optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<ProductModel> Products { get; set; } = default!;

    }
}
