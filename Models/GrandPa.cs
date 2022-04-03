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

		public GrandPa(int id, string firstName, string lastName, int age, string preferredQuote, string nickName)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			PreferredQuote = preferredQuote;
			NickName = nickName;
		}

		public string DisplayName
		{
			get
			{
				return FirstName + " " + LastName;
			}
		}
		public string DisplayNick
		{
			get
			{
				return FirstName + " \"" + NickName + "\" " + LastName;
			}
		}

		public string DisplayInfo
		{
			get
			{
				return "Likes to say" + " \"" + PreferredQuote + "\" ";
			}
		}

		public string GetImageID
		{
			get
			{
				return FirstName + " " + LastName[0] + ".jpg";
			}
		}
	}
}
