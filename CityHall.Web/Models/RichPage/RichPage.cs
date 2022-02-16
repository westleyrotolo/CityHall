using System;
using CityHall.Web.Models.HomePage;

namespace CityHall.Web.Models
{
	public class RichPage : BaseIdentityEntity<int>
	{
		public virtual ICollection<WidgetItem> WidgetItems { get; set; }
	}
}

