using System;
using CityHall.Web.Models;

namespace CityHall.Web.Services.Interfaces
{
	public interface IOfficeService
	{
		Task<Office> AddOfficeAsync(Office office);
	}
}

