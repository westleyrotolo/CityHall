using System;
namespace CityHall.Web.Models.HomePage
{
	public class WidgetItem : BaseIdentityEntity<int>
	{
		public WidgetType Widget { get; set; }
		public int Index { get; set; }
		public int PreRenderedItem { get; set; }
		public int MaxItems { get; set; }
		public bool ShowLoadMoreButton { get; set; }
		public string Source { get; set; }
		public string Background { get; set; }
		public string Header { get; set; }
	}
}

