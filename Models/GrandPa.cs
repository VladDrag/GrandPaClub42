namespace GrandPaClub42.Models
{
	public class GrandPa
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string PreferredQuote { get; set; }
		public string NickName { get; set; }

		public string DisplayName
		{
			get
			{
				return FirstName + " \"" + NickName + "\" " + LastName + ", " + Age;
			}
		}

		public string DisplayInfo
		{
			get
			{
				return "Likes to say" + " \"" + PreferredQuote + "\" ";
			}
		}
	}
}
