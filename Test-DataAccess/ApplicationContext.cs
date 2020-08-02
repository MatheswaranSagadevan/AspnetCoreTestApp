using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Test_DataAccess;

namespace Test_DataAccessRepository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new PropertyMap(modelBuilder.Entity<Property>());            
        }
    }

    internal class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ApplicationContext>();
            builder.UseSqlServer("Data Source = localhost; Initial Catalog = AspnetCoreTestDB; Integrated Security = true");
            var context = new ApplicationContext(builder.Options);
            return context;
        }
    }
}
