using System;
using AutoMapper;
using CityHall.Web.Dtos;
using CityHall.Web.Models;
using CityHall.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CityHall.Web.Controllers.V1
{
	public class OfficeController : BaseV1Controller
	{
		private readonly IMapper _mapper;
		private readonly IOfficeService _officeService;
		public OfficeController(IMapper mapper,
								IOfficeService officeService)
		{
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
			_officeService = officeService ?? throw new ArgumentNullException(nameof(officeService));
		}

		[HttpPost]
		public async Task<IActionResult> CreateOfficeAsync([FromForm]OfficeSubmitDto officeSubmitDto)
        {
			var office = _mapper.Map<Office>(officeSubmitDto);
			office = await _officeService.AddOfficeAsync(office);
			return Ok(office.Id);
        }

	}
}

