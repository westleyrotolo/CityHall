using System;
using CityHall.Web.Models.MultiTenant;

namespace CityHall.Web.Services.Interfaces
{
	public interface IClientService
	{
		Task AddClientAsync(Client client);
	}
}

