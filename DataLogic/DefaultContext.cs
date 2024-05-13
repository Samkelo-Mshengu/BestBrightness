using DataLogic.Activity;
using DataLogic.Admin;
using DataLogic.Age;
using DataLogic.Await;
using DataLogic.Branches;
using DataLogic.Countries;
using DataLogic.Events;
using DataLogic.Members;
using DataLogic.Product;
using DataLogic.Provinces;
using DataLogic.Statuses;
using DataLogic.Users;
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
            optionsBuilder.UseSqlServer(ServicesExtensions.InqolaConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<ProductModel> Products { get; set; } = default!;
        public DbSet<ActivityHistory> ActivityHistories { get; set; } = default!;
        public DbSet<AgeGroup> AgeGroups { get; set; } = default!;
        public DbSet<Awaiting> Awaitings { get; set; } = default!;
        public DbSet<Branch> Branches { get; set; } = default!;
        //public DbSet<BranchManager> BranchManagers { get; set; } = default!;
        public DbSet<County> Counties { get; set; } = default!;
        public DbSet<Event> Events { get; set; } = default!;
        public DbSet<MemberModel> Members { get; set; } = default!;
        public DbSet<Province> Provinces { get; set; } = default!;
        public DbSet<Status> Statuses { get; set; } = default!;
        public DbSet<SuperAdmin> SuperAdmins { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;

    }
}
