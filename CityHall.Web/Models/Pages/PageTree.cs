using System;
namespace CityHall.Web.Models
{
	public class PageTree : BaseIdentityEntity<int>
	{

		public int PageId { get; set; }
		public int? ParentPageTreeId { get; set; }
		public int Index { get; set; }
		public int CategoryId { get; set; }
		public virtual Category Category { get; set; }
		public virtual Page Page { get; set; }
		public virtual PageTree? ParentPageTree { get; set; }

		public virtual HashSet<PageTree> ChildPageTree { get; set; }

	}
}

