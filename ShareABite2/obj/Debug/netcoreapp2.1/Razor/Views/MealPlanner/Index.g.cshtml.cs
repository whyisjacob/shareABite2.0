#pragma checksum "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\MealPlanner\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03450fbcd8cbdaf06d1fe7e7cae4a61cae8390a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MealPlanner_Index), @"mvc.1.0.view", @"/Views/MealPlanner/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MealPlanner/Index.cshtml", typeof(AspNetCore.Views_MealPlanner_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\_ViewImports.cshtml"
using ShareABite2;

#line default
#line hidden
#line 2 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\_ViewImports.cshtml"
using ShareABite2.Models;

#line default
#line hidden
#line 1 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\MealPlanner\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03450fbcd8cbdaf06d1fe7e7cae4a61cae8390a9", @"/Views/MealPlanner/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30271edc521a734dba71f22becbc477cb261745", @"/Views/_ViewImports.cshtml")]
    public class Views_MealPlanner_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(138, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\MealPlanner\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(222, 1073, true);
            WriteLiteral(@"
<h2>Meal Planner</h2>

<p>We have many different recipes for you to include in your weekly meals. Allow us to provide better results by choosing what type of recipes you would like</p>
<div class=""row"">
	<div class=""col-sm-6"">
		<h3>Meal Type</h3>
		<button class=""btn btn-default mealType"">Breakfast</button>
		<button class=""btn btn-default mealType"">Lunch</button>
		<button class=""btn btn-default mealType"">Dinner</button>
		<button class=""btn btn-default mealType"">Dessert</button>

		<h3>Difficulty</h3>
		<button class=""btn btn-default difficulty"">Easy Please</button>
		<button class=""btn btn-default difficulty"">Up to Medium Difficulty</button>
		<button class=""btn btn-default difficulty"">It doesn't matter</button>

		<h3>Cook Time</h3>
		<button class=""btn btn-default cookTime"">Twenty Minutes or less</button>
		<button class=""btn btn-default cookTime"">Up to Fourty Minutes</button>
		<button class=""btn btn-default cookTime"">It doesn't matter</button>
	</div>
	<div class=""col-sm-6"">
		");
            WriteLiteral("more options\r\n\t</div>\r\n\t<div class=\"col-sm-12\">\r\n");
            EndContext();
#line 36 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\MealPlanner\Index.cshtml"
         if (SignInManager.IsSignedIn(User))
		{

#line default
#line hidden
            BeginContext(1340, 216, true);
            WriteLiteral("\t\t\t<h3>Recipe Source</h3>\r\n\t\t\t<button class=\"col-xs-6 btn btn-primary\" onclick=\"myRecipes()\">Use my recipes only</button>\r\n\t\t\t<button class=\"col-xs-6 btn btn-primary\" onclick=\"allRecipes()\">Use all recipes</button>\r\n");
            EndContext();
#line 41 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\MealPlanner\Index.cshtml"
		}
		else
		{

#line default
#line hidden
            BeginContext(1574, 117, true);
            WriteLiteral("\t\t\t<h3>Recipe Source</h3>\r\n\t\t\t<button class=\"col-xs-6 btn btn-primary\" onclick=\"allRecipes()\">Find Recipes</button>\r\n");
            EndContext();
#line 46 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\MealPlanner\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(1696, 983, true);
            WriteLiteral(@"	</div>
</div>
<div class=""row"">
	<div class=""col-sm-12"">
		<hr />

		<h2>Suggested <span id=""mealtype""></span> Plans</h2>
		<h5>Difficulty: <span id=""difficultyType""></span></h5>
		<h5><img width='15px' src='images/clock.png' alt='Total Prep and Cook Time' class='directions_image'> <span id=""timeToCook""></span></h5>

		<table class=""table"">
			<thead>
				<tr>
					<td>Sunday</td>
					<td>Monday</td>
					<td>Tuesday</td>
					<td>Wednesday</td>
					<td>Thursday</td>
					<td>Friday</td>
					<td>Saturday</td>
				</tr>
			</thead>
			<tbody id=""mealList"">
				<tr>
					<td id=""sunday"" class=""mealDisplay""></td>
					<td id=""monday"" class=""mealDisplay""></td>
					<td id=""tuesday"" class=""mealDisplay""></td>
					<td id=""wednesday"" class=""mealDisplay""></td>
					<td id=""thursday"" class=""mealDisplay""></td>
					<td id=""friday"" class=""mealDisplay""></td>
					<td id=""saturday"" class=""mealDisplay""></td>

				</tr>
			</tbody>
		</table>

");
            EndContext();
            BeginContext(3123, 891, true);
            WriteLiteral(@"	</div>
</div>

<script>
	let chosenRecipes = [],
		recipeChosenAlready,
		//recipeCount = recipes.length,
		daysOfWeek = [""Sunday"", ""Monday"", ""Tuesday"", ""Wednesday"", ""Thursday"", ""Friday"", ""Saturday""],
		x,
		savedRecipes,
		mealType,
		difficulty,
		cookTime;

	$(document).ready(function () {
		getSavedRecipeCount()
		console.log(savedRecipes)
	})


	$('.mealType').on('click', function () {
		mealType = $(this).html();
	})
	$('.difficulty').on('click', function () {
		difficulty = $(this).html();
	})
	$('.cookTime').on('click', function () {
		cookTime = $(this).html();
	})

	function myRecipes() {
		$('#mealtype').html(mealType)
		$('#difficultyType').html(difficulty)
		$('#timeToCook').html(cookTime)

		//get MY recipes
		let myRecipes = [];
		var settings = {
			""async"": true,
			""crossDomain"": true,
			""url"": ""/api/Recipe/UserRecipes/");
            EndContext();
            BeginContext(4015, 27, false);
#line 145 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\MealPlanner\Index.cshtml"
                                       Write(UserManager.GetUserId(User));

#line default
#line hidden
            EndContext();
            BeginContext(4042, 3280, true);
            WriteLiteral(@""",
			""method"": ""GET"",
			""headers"": {
				""Content-Type"": ""application/x-www-form-urlencoded"",
				""cache-control"": ""no-cache"",
			},
			""data"": """"
		}

		$.ajax(settings).done(function (response) {
			console.log(""Using MY MY MY Reciep[s"");
			response.forEach(function (val) {
				myRecipes.push(val)
				console.log(myRecipes)
			})
		});

		chosenRecipes = [];
		$('.mealDisplay').each(function (i, val) {
			console.log($(val).attr('id'))
			//Clear list
			$(val).html(' ');
			var rn = randomNumber()
			console.log(rn)
		//	if (x == ""ChooseNewRecipe"") {
		//		randomNumber()
		//		if (x !== ""ChooseNewRecipe"") {
		//			$.get(""/api/Recipe/"" + x, function (data) {
		//				buildDisplay(data, val, i)

		//			})
		//		} else {
		//			randomNumber()
		//			if (x !== ""ChooseNewRecipe"") {
		//				$(val).$.get(""/api/Recipe/"" + x, function (data) {
		//					buildDisplay(data, val, i)
		//				})
		//			} else {
		//			}
		//		}
		//	} else {
		//		$.get(""/api/Recipe/"" + x, funct");
            WriteLiteral(@"ion (data) {
		//			buildDisplay(data, val, i)
		//		})
		//	}
		})
	}

	function allRecipes() {
		console.log(mealType)
		console.log(difficulty)
		console.log(cookTime)
		generateRecipeDisplay()
	}

	function generateRecipeDisplay() {
		$('#mealtype').html(mealType)
		$('#difficultyType').html(difficulty)
		$('#timeToCook').html(cookTime)

		chosenRecipes = [];
		$('.mealDisplay').each(function (i, val) {
			//Clear list
			$(val).html(' ');
			randomNumber()
			if (x == ""ChooseNewRecipe"") {
				randomNumber()
				if (x !== ""ChooseNewRecipe"") {
					$.get(""/api/Recipe/"" + x, function (data) {
						buildDisplay(data, val, i)

					})
				} else {
					randomNumber()
					if (x !== ""ChooseNewRecipe"") {
						$(val).$.get(""/api/Recipe/"" + x, function (data) {
							buildDisplay(data, val, i)
						})
					} else {
					}
				}
			} else {
				$.get(""/api/Recipe/"" + x, function (data) {
					buildDisplay(data, val, i)
				})
			}
		})
	}
	function buildDisplay(da");
            WriteLiteral(@"ta, val, i) {
		console.log(data)
		$(val).html(""<h4>"" + data.recipeName + ""</h4> <img width='150px' src='"" + data.imgUrl + ""' alt='"" + data.recipeName + ""'><br><p><img width='15px' src='images/clock.png' alt='Total Prep and Cook Time' class='directions_image'> "" + data.cookTime + "" minutes<br><img width='15px' src='images/servings.png' alt='Servings' class='directions_image'> "" + data.servings + "" servings</p> <a href='/view/recipe/"" + data.recipeId + ""' target='_blank'>View Recipe</a>"")

	}
	function randomNumber() {
		var randomNumber = Math.floor(Math.random() * savedRecipes)
		var numbExists = chosenRecipes.includes(randomNumber)
		if (numbExists) {
			x = ""ChooseNewRecipe""
			return x
		} else {
			chosenRecipes.push(randomNumber)
			x = randomNumber
			return x
		}
	}
	function getSavedRecipeCount() {
		$.get(""/api/Recipe"", function (data) {
			savedRecipes = data.length;
			console.log(savedRecipes)
		})
	}
	$('#scanRecipes').on('click', function () {
		$('#scanRecipes').html('");
            WriteLiteral("Refresh List\')\r\n\t\tgenerateRecipeDisplay()\r\n\t})\r\n\tfunction getRecipeInfo(id) {\r\n\t\t$.get(\"/api/Recipe/\" + id, function (data) {\r\n\t\t\tsavedRecipes = data.length;\r\n\t\t\tconsole.log(savedRecipes)\r\n\t\t})\r\n\t}\r\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
