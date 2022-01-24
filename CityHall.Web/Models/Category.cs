using System;
namespace CityHall.Web.Models
{
	public class Category : BaseIdentityEntity<int>
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public string CoverUrl { get; set; }
		public bool IsFeatured { get; set; }
		public int Index { get; set; }

	}
}

