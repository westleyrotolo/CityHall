﻿using System;
using Microsoft.AspNetCore.Identity;

namespace CityHall.Web.Models.Users
{
	public class UserRole : IdentityRole<Guid>
	{
		public UserRole()
		{
		}
	}
}

