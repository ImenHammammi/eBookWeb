using Microsoft.AspNetCore.Mvc;

namespace eBookWeb.Areas.Admin.Controllers
{
	public class OrderController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
