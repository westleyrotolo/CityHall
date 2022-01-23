using System;
namespace CityHall.Web.Models
{
	public class PageDocument : BaseEntity
	{
		public int PageId { get; set; }
		public int DocumentId { get; set; }

		public virtual Page Page { get; set; }
		public virtual Document Document { get; set; }
	}
}

