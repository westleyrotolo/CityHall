﻿using System;
namespace CityHall.Web.Models
{
	public class Page : BaseEntity
	{
		public string Title { get; set; }
		public string BriefDescription { get; set; }
		public string ImageUrl { get; set; }
		public string HtmlContent { get; set; }
		public int? CoordinateId { get; set; }
		public DateTime? ExpiresDate { get; set; }
		public DateTime? StartDate { get; set; }
		public virtual ICollection<Topic> Topics { get; set; }
		public virtual ICollection<PageDocument> PageDocuments { get; set; }
		public virtual Coordinate? Coordinate { get; set; }


	} 
}
