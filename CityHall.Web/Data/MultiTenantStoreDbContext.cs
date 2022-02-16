using System;
using CityHall.Web.Models.MultiTenant;
using Finbuckle.MultiTenant;
using Finbuckle.MultiTenant.Stores;
using Microsoft.EntityFrameworkCore;

namespace CityHall.Web.Data
{
	public class MultiTenantStoreDbContext : EFCoreStoreDbContext<Client>
	{
		private readonly IConfiguration _configuration;
        public MultiTenantStoreDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
			_configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Use InMemory, but could be MsSql, Sqlite, MySql, etc...
			optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
			base.OnConfiguring(optionsBuilder);
		}
	}
}

