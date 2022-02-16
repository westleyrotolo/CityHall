using System;
using AutoMapper;
using CityHall.Web.Dtos;
using CityHall.Web.Models.MultiTenant;
using CityHall.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CityHall.Web.Controllers.V1
{
	public class ClientController : BaseV1Controller
	{
		private readonly IClientService _clientService;
		private readonly IMapper _mapper;
		public ClientController(
				IClientService clientService,
				IMapper mapper
			)
		{
			_clientService = clientService;
			_mapper = mapper;
		}

		[HttpPost]
		public async Task<IActionResult> AddClient([FromForm]ClientSubmitDto clientSubmitDto)
        {
			var client = _mapper.Map<Client>(clientSubmitDto);
			await _clientService.AddClientAsync(client);
			return Ok(client.Id);
        }
	}
}

