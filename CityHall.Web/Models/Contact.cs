using System;
namespace CityHall.Web.Models
{
	public class Contact : BaseIdentityEntity<int>
	{
		public string Content { get; set; }
		public int CoordinateId { get; set; }
		public virtual Coordinate Coordinate { get; set; }
		public virtual ICollection<ContactHyperLink> HyperLinks { get; set; }
	}
}

