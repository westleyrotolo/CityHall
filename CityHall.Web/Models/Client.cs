using System;
namespace CityHall.Web.Models
{
	public class Client : BaseIdentityEntity<int>
	{
		public string CityTitle { get; set; }
		public string CitySubtitle { get; set; }
		public string Region { get; set; }
		
		public virtual ICollection<FollowUs> FollowUs { get; set; }
	}
}

