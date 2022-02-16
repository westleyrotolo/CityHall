using System;
using CityHall.Web.Models.Users;

namespace CityHall.Web.Models
{
	public class Office : BaseIdentityEntity<int>
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public virtual ICollection<UserOffice> UserOffices { get; set; }
	} 
}

