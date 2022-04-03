using GrandPaClub42.Models;
using GrandPaClub42.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace GrandPaClub42.Controllers
{
	public class GrandPaController : Controller
	{
		private GrandPaRepository _grandPaRepository = null;
		public GrandPaController()
		{
			_grandPaRepository = new GrandPaRepository();
		}

		public IActionResult Index(int? id)
		{
			var grandPas = _grandPaRepository.GetGrandPas();
			return View(grandPas);
		}

		public IActionResult Detail(int? id)
		{
			if (id == null)
				return View(_grandPaRepository.GetGrandPa(0));
			foreach (var gpa in _grandPaRepository.GetGrandPas())
			{
				if (gpa.Id == id)
					return View(gpa);
			}
			return View(_grandPaRepository.GetGrandPa(0));
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