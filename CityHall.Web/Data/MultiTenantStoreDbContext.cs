using System;
using CityHall.Web.Models.MultiTenant;
using Finbuckle.MultiTenant;
using Finbuckle.MultiTenant.Stores;
using Microsoft.EntityFrameworkCore;

namespace CityHall.Web.Data
{
	public class MultiTenantStoreDbContext : EFCoreStoreDbContext<Client>
	{
        public MultiTenantStoreDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Use InMemory, but could be MsSql, Sqlite, MySql, etc...
			optionsBuilder.UseNpgsql("EfCoreStoreSampleConnectionString");
			base.OnConfiguring(optionsBuilder);
		}
	}
}

