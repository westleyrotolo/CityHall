using System;
using Microsoft.AspNetCore.Identity;

namespace CityHall.Web.Models.Users
{
	public class User : IdentityUser<Guid>
	{
		public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}

