using GrandPaClub42.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace GrandPaClub42.Controllers
{
	public class GrandPaController : Controller
	{
		private GrandPa _grandPa = null;
		public GrandPaController()
		{
			_grandPa = new GrandPa(
				0,
				"Vlad",
				"Dragomir",
				31,
				"Sounds like a you-problem, lad!",
				"Good of it");
		}

		public IActionResult Index()
		{
			var grandPa = _grandPa;
			return View(grandPa);
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