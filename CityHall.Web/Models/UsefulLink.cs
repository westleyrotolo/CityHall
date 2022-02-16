using System;
namespace CityHall.Web.Models
{
	public class UsefulLink : BaseIdentityEntity<int>
	{
		public string Title { get; set; }
		public string Url { get; set; }
		public UsefulLinkType LinkType { get; set; }
	}
	public enum UsefulLinkType : byte
    {
		Footer = 0,
		Policy = 1
    }
}

