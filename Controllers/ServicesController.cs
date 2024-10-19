using Microsoft.AspNetCore.Mvc;

namespace HairHarmonySalon.Controllers
{
	public class ServicesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
