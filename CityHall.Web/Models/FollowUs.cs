using System;
namespace CityHall.Web.Models
{
	public class FollowUs : BaseIdentityEntity<int>
	{
		public string Url { get; set; }
		public string Name { get; set; }
		public string Icon { get; set; }
	}
}

