using System;

namespace flavorsome_delights.Models;

public class Recipe
{
	public Recipe()
	{
		public int Id { get; set; }
		public string title { get; set; }
		public int user_id { get; set; }
		public int serves { get; set; }
		public string howToPrepare { get; set; }
		public string complexity { get; set; }
		public string preparationTime { get; set; }
}
}
