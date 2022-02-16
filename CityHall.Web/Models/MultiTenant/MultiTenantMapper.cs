using System;
using AutoMapper;
using CityHall.Web.Dtos;

namespace CityHall.Web.Models.MultiTenant
{
	public class MultiTenantMapper : Profile
	{
		public MultiTenantMapper()
		{
			CreateMap<ClientSubmitDto, Client>()
				.ForMember(x => x.Identifier, x => x.MapFrom(x => x.CityTitle.Replace(" ", "")))
				.ForMember(x => x.Name, x => x.MapFrom(x => x.CityTitle))
				.ForMember(x => x.Logo, x => x.MapFrom(x => string.Empty))
				.ForMember(x => x.Id, x => x.MapFrom(x => Guid.NewGuid().ToString()));
		}
	}
}

