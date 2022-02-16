using System;
using CityHall.Web.Models;
using CityHall.Web.Repositories.Interfaces;
using CityHall.Web.Services.Interfaces;

namespace CityHall.Web.Services
{
	public class OfficeService : IOfficeService
	{
        private readonly IGenericRepository<Office> _officeRepository;
		public OfficeService(IGenericRepository<Office> officeRepository)
		{
            _officeRepository = officeRepository ?? throw new ArgumentNullException(nameof(officeRepository));
		}

        public Task<Office> AddOfficeAsync(Office office)
        {
            return _officeRepository.AddAsync(office);
        }
    }
}

