using System;
using CityHall.Web.Models.Users;
using Finbuckle.MultiTenant;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CityHall.Web.Data
{
	public class ApplicationDbContext : IdentityDbContext<User, UserRole, Guid>
	{
		private ITenantInfo _tenantInfo { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(_tenantInfo.ConnectionString);
		}

        public ApplicationDbContext(
			ITenantInfo tenantInfo,
			DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
			_tenantInfo = tenantInfo;
		}
	}
}

