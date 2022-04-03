using GrandPaClub42.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GrandPaClub42.Controllers
{
	public class GrandPaController : Controller
	{
		//private readonly ILogger<GrandPaController> _logger;

		//public GrandPaController(ILogger<GrandPaController> logger)
		//{
		//	_logger = logger;

		//}
		public GrandPaController()
		{
			GrandPa grandPa = new GrandPa()
			{

			};
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}