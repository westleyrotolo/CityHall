using System;
namespace CityHall.Web.Models
{
	public class Contact : BaseIdentityEntity<int>
	{
		public string Content { get; set; }

		public virtual ICollection<ContactHyperLink> HyperLinks { get; set; }
	}
}

