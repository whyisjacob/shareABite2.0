using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLI.Models
{
    public class NewRecipe
    {
        [Key]
        public long RecipeId { get; set; }

        private string _key;
        public string RecipeKey
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(RecipeName.ToLower(), "[^a-z0-9]", "-") + "-" + RecipeId;
                }
                return _key;
            }
            set { _key = value; }
        }

        [Display(Name = "Recipe Name")]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(500, MinimumLength = 2, ErrorMessage = "The title must be at least 2 characters long")]
        public string RecipeName { get; set; }

        [Display(Name = "Recipe Story")]
        [Required]
        [MinLength(100, ErrorMessage = "Stories must be a minimum of 100 characters long")]
        [DataType(DataType.MultilineText)]
        public string RecipeStory { get; set; }

        [Display(Name = "Recipe Description")]
        [Required]
        [MinLength(100, ErrorMessage = "RecipeDescription must be a minimum of 100 characters long")]
        [DataType(DataType.MultilineText)]
        public string RecipeDescription { get; set; }

        [Display(Name = "Recipe Ingredients")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string RecipeIngredients { get; set; }

        [Display(Name = "Oven Temprature")]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Please enter a number or None as the temprature")]
        public String RecipeOvenTemp { get; set; }

        [Display(Name = "Preparation Time")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int RecipePrepTime { get; set; }

        [Display(Name = "Cook Time")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int RecipeCookTime { get; set; }

        [Display(Name = "Number of Servings")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int RecipeServings { get; set; }

        [Display(Name = "Recipe Directions")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string RecipeDirections { get; set; }

        [Display(Name = "Image")]
        [Required]
        [DataType(DataType.ImageUrl)]
        public string RecipeImageUrl { get; set; }

        [Display(Name = "Do you want this recipe public?")]
        [Required]
        public bool RecipePublic { get; set; }

        [Required]
        public int RecipeAuthor { get; set; }

        [Required]
        public DateTime RecipeCreated { get; set; }

        [Required]
        public DateTime RecipeUpdated { get; set; }
    }
}
