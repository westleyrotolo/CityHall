using System;
namespace CityHall.Web.Models
{
	public class Footer : BaseIdentityEntity<int>
	{
		public bool HasSubCategories { get; set; }
		public bool HasNewsletter { get; set; }
		public int FeaturedPageId { get; set; }
		public virtual Page FeaturedPage {get;set; }
	}
}

