using System;
using CityHall.Web.Models;
using CityHall.Web.Models.HomePage;
using CityHall.Web.Models.Users;
using Finbuckle.MultiTenant;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CityHall.Web.Data
{
	public class ApplicationDbContext : MultiTenantIdentityDbContext<User, UserRole, Guid>
	{
		private ITenantInfo _tenantInfo { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(_tenantInfo.ConnectionString);
		
		}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
			builder.Entity<PageTree>()
				.HasOne(e => e.Page)
				.WithOne(e => e.PageTree)
				.HasForeignKey<Page>(e => e.PageTreeId)
				.IsRequired(false)
				.OnDelete(DeleteBehavior.SetNull);

			builder.Entity<UserOffice>().HasKey(x => new { x.UserId, x.OfficeId });
			builder.Entity<User>().Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Entity<UserRole>().Property(x => x.Id).ValueGeneratedOnAdd();
		}



        public ApplicationDbContext(
			ITenantInfo tenantInfo,
			DbContextOptions<ApplicationDbContext> options)
			: base(tenantInfo, options)
		{
			_tenantInfo = tenantInfo;
		}


		public ApplicationDbContext(
			ITenantInfo tenantInfo)
			: base(tenantInfo)
		{
			_tenantInfo = tenantInfo;
		}


		public DbSet<RichPage> RichPages { get; set; }
		public DbSet<WidgetItem> WidgetItems { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<ContactHyperLink> ContactHyperLinks { get; set; }
		public DbSet<Coordinate> Coordinates { get; set; }
		public DbSet<FollowUs> FollowUs { get; set; }
		public DbSet<Office> Offices { get; set; }
		public DbSet<Footer> Footers { get; set; }
		public DbSet<Page> Pages { get; set; }
		public DbSet<PageDraft> PageDrafts { get; set; }
		public DbSet<SmallCard> SmallCards { get; set; }
		public DbSet<Topic> Topics { get; set; }
		public DbSet<UsefulLink> UsefulLinks { get; set; }
  	}
}

