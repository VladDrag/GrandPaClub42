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
				"Sounds like a you-problem, lad!",
				"Good of it"),
			new GrandPa(
				1,
				"Bethan",
				"Williams",
				30,
				"Castra's the best, sanction the rest!",
				"Big Willy"),
			new GrandPa(
				2,
				"Evangelos",
				"Spyromilios",
				60,
				"Ο υπέροχος κώδικας του Vlad μου θύμισε έντονα τα Mititei.",
				"Where my Blockchain at?"
				),
			new GrandPa(
				3,
				"Kostas",
				"Chaniotakis",
				80,
				"Ο Χριστός της Μητέρας σου",
				"Griechischer Wein"),
			new GrandPa(
				4,
				"Alistair",
				"Kane",
				10,
				"I only want to be evaluated by the on-site people!",
				"Honorary Grandpa"
				)
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
