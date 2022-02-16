using System;
namespace CityHall.Web.Dtos
{
	public class ClientSubmitDto
	{
		public string CityTitle { get; set; }
		public string? CitySubtitle { get; set; }
		public string Region { get; set; }
		public IFormFile? Logo { get; set; }
		public bool HasNewsletter { get; set; }
	}
}

