using System.Web;
using System.Web.Mvc;

namespace HerbCollection_IndividualAuth
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
