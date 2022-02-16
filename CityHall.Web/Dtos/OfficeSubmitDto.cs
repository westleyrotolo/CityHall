using System;
namespace CityHall.Web.Dtos
{
	public class OfficeSubmitDto
	{
		public string Title { get; set; }
		public string? Description { get; set; }
		public IFormFile? Image { get; set; }
	}
}

