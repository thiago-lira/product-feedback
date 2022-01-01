using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Core.Data
{
    public class ApplicationContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public ApplicationContext(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("db"));
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasKey(u => u.Id);
        }
    }
}
