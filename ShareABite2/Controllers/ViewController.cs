using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShareABite2.Data;
using ShareABite2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;

namespace ShareABite2.Controllers
{
	//Public methods for recipes
    public class ViewController : Controller
    {
		private readonly ApplicationDbContext _context;

		public ViewController(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Recipe(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var recipeModel = await _context.RecipeModel
			   .FirstOrDefaultAsync(m => m.RecipeId == id);
			if (recipeModel == null)
			{
				return NotFound();
			}

			return View(recipeModel);

		}
	}
}