using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShareABite2.Data;
using ShareABite2.Models;

namespace ShareABite2.Controllers.api
{
	[Route("api/[controller]")]
	[ApiController]
	public class RecipeController : ControllerBase
	{
		private readonly ApplicationDbContext _context;

		public RecipeController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: api/Recipe
		[HttpGet]
		public IEnumerable<RecipeModel> GetRecipeModel()
		{
			return _context.RecipeModel;
		}



		// GET: api/Recipe/5
		[HttpGet("{id}")]
		public async Task<IActionResult> GetRecipeModel([FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var recipeModel = await _context.RecipeModel.FindAsync(id);

			if (recipeModel == null)
			{
				return NotFound();
			}

			return Ok(recipeModel);
		}

		// PUT: api/Recipe/5
		[HttpPut("{id}")]
		public async Task<IActionResult> PutRecipeModel([FromRoute] int id, [FromBody] RecipeModel recipeModel)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != recipeModel.RecipeId)
			{
				return BadRequest();
			}

			_context.Entry(recipeModel).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!RecipeModelExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		// POST: api/Recipe
		[HttpPost]
		public async Task<IActionResult> PostRecipeModel([FromBody]RecipeModel recipeModel)
		{
			Debug.WriteLine(recipeModel);
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			_context.RecipeModel.Add(recipeModel);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetRecipeModel", new { id = recipeModel.RecipeId }, recipeModel);
		}

		// DELETE: api/Recipe/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteRecipeModel([FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var recipeModel = await _context.RecipeModel.FindAsync(id);
			if (recipeModel == null)
			{
				return NotFound();
			}

			_context.RecipeModel.Remove(recipeModel);
			await _context.SaveChangesAsync();

			return Ok(recipeModel);
		}

		private bool RecipeModelExists(int id)
		{
			return _context.RecipeModel.Any(e => e.RecipeId == id);
		}

		

	}
}