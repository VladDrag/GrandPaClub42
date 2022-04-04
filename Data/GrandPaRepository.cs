using GrandPaClub42.Models;

namespace GrandPaClub42.Data
{
	public class GrandPaRepository
	{
		private static GrandPa[] _grandPas = new GrandPa[]
		{
			new GrandPa(
				0,
				"Vlad",
				"Dragomir",
				31,
				"Back in my day...",
				"Good of it"),
			new GrandPa(
				1,
				"Bethan",
				"Williams",
				30,
				"Ydych chi eisiau siarad Cymraeg?",
				"Big Willy"),
			new GrandPa(
				2,
				"Evangelos",
				"Spyromilios",
				60,
				"I unironically watch Formula 1.",
				"Have you heard of Solidity?"
				),
			new GrandPa(
				3,
				"Kostas",
				"Chaniotakis",
				80,
				"Ο Χριστός της Μητέρας σου!",
				"Griechischer Wein"),
			new GrandPa(
				4,
				"Alistair",
				"Kane",
				10,
				"Only on-site people evaluate me!",
				"Honorary Grandpa-child"
				),
			new GrandPa(
				5,
				"Dejan",
				"Zivanov",
				30,
				"I want work in Europe.",
				"I heff question!"
				),
			new GrandPa(
				6,
				"Tim",
				"Gerdes",
				31,
				"Haha, Bee-thong!",
				"Calm down, Charlie!"
				),
			new GrandPa(
				7,
				"Valentin",
				"Simeonov",
				35,
				"Why, yes, I do speak network binary.",
				"TCP/IP")
		};

		public GrandPa GetGrandPa(int id)
		{
			GrandPa grandpaReturn = null;
			foreach (var gpa in _grandPas)
			{
				if (gpa.Id == id)
				{
					grandpaReturn = gpa;
					break;
				}
			}
			return grandpaReturn;
		}

		public GrandPa[] GetGrandPas()
		{
			return _grandPas;
		}


	}
}
