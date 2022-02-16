using System;
using CityHall.Web.Data;
using CityHall.Web.Helpers;
using CityHall.Web.Models.MultiTenant;
using CityHall.Web.Services.Interfaces;
using Finbuckle.MultiTenant;

namespace CityHall.Web.Services
{
	public class ClientService : IClientService
	{
        private readonly IConfiguration _configuration;
        private readonly IMultiTenantStore<Client> _store;

        public ClientService(IConfiguration configuration,
                             IMultiTenantStore<Client> store)
		{
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _store = store ?? throw new ArgumentNullException(nameof(store));

		}

        public async Task AddClientAsync(Client client)
        {
            var item = await _store.TryGetByIdentifierAsync(client.Identifier);
            if (item == null)
            {
                var templateConnection = _configuration.GetConnectionString("TemplateConnection");
                client.ConnectionString = templateConnection.FormatMe(client.Identifier);
                await _store.TryAddAsync(client);
                var applicationDbContext = new ApplicationDbContext(client);
                await applicationDbContext.Database.EnsureCreatedAsync();
            }
        }
    }
}

