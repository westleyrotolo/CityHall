using System;
using AutoMapper;
using CityHall.Web.Dtos;

namespace CityHall.Web.Models
{
	public class ModelsMapper : Profile
	{
		public ModelsMapper()
		{
			CreateMap<OfficeSubmitDto, Office>()
				.ForMember(src => src.Title, dst => dst.MapFrom(x => x.Title))
				.ForMember(src => src.Description, dst => dst.MapFrom(x => x.Description))
				;
		}
	}
}

