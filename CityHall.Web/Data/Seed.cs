using System;
using Finbuckle.MultiTenant;

namespace CityHall.Web.Data
{
	public class Seed
	{
		public Seed()
		{
		}
        public async Task SetupStore(IMultiTenantStore<TenantInfo> store)
        {
            await store.TryAddAsync(new TenantInfo { Id = "tenant-cityhall-241", Identifier = "CityHall", Name = "CityHall", ConnectionString = "finbuckle_conn_string" });
            await store.TryAddAsync(new TenantInfo { Id = "tenant-rutino-235", Identifier = "Rutino", Name = "Rutino", ConnectionString = "initech_conn_string" });
        }
    }
}

