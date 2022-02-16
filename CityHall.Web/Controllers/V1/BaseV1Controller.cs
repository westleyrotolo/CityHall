using System;
using Microsoft.AspNetCore.Mvc;

namespace CityHall.Web.Controllers.V1
{
	[ApiController]
	[Route("api/[controller]")]
	[ApiVersion("1.0")]
	public class BaseV1Controller : ControllerBase
	{
		public BaseV1Controller()
		{
		}
	}
}

