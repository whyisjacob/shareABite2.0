using CLI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CLI.Data;

namespace CLI.Controllers
{
    [Authorize]
    public class RecipesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public RecipesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult NewRecipe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewRecipe(HttpPostAttribute post)
        {
            Debug.WriteLine(post);

            if (!ModelState.IsValid)
                return View();


            return View();
        }

    }
}