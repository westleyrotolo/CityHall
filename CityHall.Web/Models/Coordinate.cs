using System;
namespace CityHall.Web.Models
{
	public class Coordinate : BaseIdentityEntity<int>
	{
		public string DisplayName { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
	}
}

