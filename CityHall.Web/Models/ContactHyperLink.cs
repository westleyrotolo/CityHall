using System;
namespace CityHall.Web.Models
{
	public class ContactHyperLink : BaseIdentityEntity<int>
	{
		public string Title { get; set; }
		public string Link { get; set; }

		public int ContactId { get; set; }
		public virtual Contact Contact { get;set; }
	}
}

