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
	[Authorize]

	public class RecipeController : Controller
	{
		private readonly ApplicationDbContext _context;

		public RecipeController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: Recipe
		public async Task<IActionResult> Index()
		{
			string userInfo = User.Identity.GetUserId();
			return View(await _context.RecipeModel.Where(p => p.UserId == userInfo).ToListAsync());
		}

		// GET: Recipe/Details/5
		public async Task<IActionResult> Details(int? id)
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

		// GET: Recipe/UserRecipes?Userid={UserId}
		public async Task<IActionResult> UserRecipes(string gorilla, string userInfo)
		{
			if (userInfo == null)
			{
				return NotFound();
			}

			//var recipeModel = await _context.RecipeModel
			//	._context.RecipeModel.Select(m => m.UserId == userInfo);
			var recipeModel = _context.RecipeModel.Where(p => p.UserId == userInfo);

			if (recipeModel == null)
			{
				return NotFound();
			}

			return new JsonResult(recipeModel);

			//return View(recipeModel);
		}

		


		// GET: Recipe/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Recipe/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("RecipeId,RecipeName,DateAdded,DateEdited,Story,Description,ImgUrl,OvenTemp,Servings,PrepTime,CookTime,Public,IngredientsJson,DirectionsJson,UserId, RecipeGenre, Difficulty")] RecipeModel recipeModel)
		{
			recipeModel.DateAdded = DateTime.Now;
			recipeModel.DateEdited = DateTime.Now;
			if (ModelState.IsValid)
			{
				_context.Add(recipeModel);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(recipeModel);
		}

		// GET: Recipe/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var recipeModel = await _context.RecipeModel.FindAsync(id);
			if (recipeModel == null)
			{
				return NotFound();
			}
			return View(recipeModel);
		}

		// POST: Recipe/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("RecipeId,RecipeName,DateAdded,DateEdited,Story,Description,ImgUrl,OvenTemp,Servings,PrepTime,CookTime,Public,IngredientsJson,DirectionsJson,UserId, RecipeGenre, Difficulty")] RecipeModel recipeModel)
		{
			if (id != recipeModel.RecipeId)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(recipeModel);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!RecipeModelExists(recipeModel.RecipeId))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(recipeModel);
		}

		// GET: Recipe/Delete/5
		public async Task<IActionResult> Delete(int? id)
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

		// POST: Recipe/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var recipeModel = await _context.RecipeModel.FindAsync(id);
			_context.RecipeModel.Remove(recipeModel);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool RecipeModelExists(int id)
		{
			return _context.RecipeModel.Any(e => e.RecipeId == id);
		}
		//GET: Recipe/MostRecentRecipes/id
		public IActionResult MostRecentRecipes( int id)
		{

			var recipeModel = (from p in _context.RecipeModel
							   orderby p.RecipeId descending
							   select p).Take(id);


			return Ok(recipeModel);
		}

		//GET: Recipe/MostRecentRecipes
		public IActionResult MyMostRecentRecipes(string userInfo)
		{

			var recipeModel = _context.RecipeModel
								  .Where(r => r.UserId == userInfo)
								  .OrderBy(r => r.RecipeId)
								  .Take(3)
								  .ToList();

			return Ok(recipeModel);
		}


		//GET: Recipe/MostRecentRecipes
		public IActionResult CountUserRecipes(string userInfo)
		{

			var count = _context.RecipeModel.Count(t => t.UserId == userInfo);

			return Ok(count);
		}
		// GET: api/Recipe?userId={{userId}}
		[HttpGet]
		public IActionResult GetMyRecipes(string userInfo)
		{

			var recipeModel = _context.RecipeModel.Where(p => p.UserId == userInfo);

			return new JsonResult(recipeModel);
		}
	}
}
