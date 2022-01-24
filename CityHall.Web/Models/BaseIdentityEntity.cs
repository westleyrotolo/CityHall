using System;
using CityHall.Web.Models.Users;

namespace CityHall.Web.Models
{
	public class BaseIdentityEntity<T> : BaseEntity where T : struct
	{
		public T Id { get; set; }
		public User? CreatedBy { get; set; }
		public User? UpdatedBy { get; set; }
	}
}

