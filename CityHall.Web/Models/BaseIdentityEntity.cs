using System;
namespace CityHall.Web.Models
{
	public class BaseIdentityEntity<T> : BaseEntity where T : struct
	{
		public T Id { get; set; }
	}
}

