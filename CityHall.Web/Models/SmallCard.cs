using System;
namespace CityHall.Web.Models
{
	public class SmallCard : BaseIdentityEntity<int>
	{
		public string Title { get; set; }
		public string Subtile { get; set; }
		public string BackgroundColor { get; set; }
		public string TextColor { get; set; }
		public string IconUrl { get; set; }
		public string ImageUrl { get; set; }
		public string Link { get; set; }
	}
}

