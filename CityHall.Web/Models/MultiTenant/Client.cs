using System;
using Finbuckle.MultiTenant;

namespace CityHall.Web.Models.MultiTenant
{
	public class Client : TenantInfo
	{	
		public string CityTitle { get; set; }
		public string CitySubtitle { get; set; }
		public string Region { get; set; }
		public string Logo { get; set; }
		public bool HasNewsletter { get; set; }
	}
}

