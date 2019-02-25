using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShareABite2.Models
{
	public class RecipeModel
	{
		[Key]
		public int RecipeId { get; set; }
		public string RecipeName { get; set; }
		public DateTime DateAdded { get; set; }
		public DateTime DateEdited { get; set; }
		public string Story { get; set; }
		public string Description { get; set; }
		public string ImgUrl { get; set; }
		public string OvenTemp { get; set; }
		public string Servings { get; set; }
		public int PrepTime { get; set; }
		public int CookTime { get; set; }
		public bool Public { get; set; }
		public string IngredientsJson { get; set; }
		public string DirectionsJson { get; set; }
		public string UserId { get; set; }
		public int RecipeGenre { get; set; }//dinner, lunch, breakfast
		public int Difficulty { get; set; }
		//public string RecipeTags { get; set; }
		
	}
}
