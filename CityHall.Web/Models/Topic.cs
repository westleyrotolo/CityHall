using System;
namespace CityHall.Web.Models
{
	public class Topic : BaseIdentityEntity<int>
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public string COverUrl { get; set; }
	}
}

