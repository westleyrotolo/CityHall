using System;
namespace CityHall.Web.Models.Users
{
	public class UserOffice : BaseEntity
	{
		public int OfficeId { get; set; }
		public Guid UserId { get; set; }
		public virtual User User { get; set; }
		public virtual Office Office { get; set; }
	}
}

