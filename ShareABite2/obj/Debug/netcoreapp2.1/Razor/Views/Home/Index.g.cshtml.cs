#pragma checksum "C:\Users\Acer_Aspire\Desktop\Code_repo\shareABite2.0\ShareABite2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2e26ec1d47486901a8555ddfe58f5a43198a347"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Acer_Aspire\Desktop\Code_repo\shareABite2.0\ShareABite2\Views\_ViewImports.cshtml"
using ShareABite2;

#line default
#line hidden
#line 2 "C:\Users\Acer_Aspire\Desktop\Code_repo\shareABite2.0\ShareABite2\Views\_ViewImports.cshtml"
using ShareABite2.Models;

#line default
#line hidden
#line 1 "C:\Users\Acer_Aspire\Desktop\Code_repo\shareABite2.0\ShareABite2\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e26ec1d47486901a8555ddfe58f5a43198a347", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30271edc521a734dba71f22becbc477cb261745", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_loggedin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_HeroSlider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(136, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Acer_Aspire\Desktop\Code_repo\shareABite2.0\ShareABite2\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
#line 8 "C:\Users\Acer_Aspire\Desktop\Code_repo\shareABite2.0\ShareABite2\Views\Home\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
            BeginContext(221, 1, true);
            WriteLiteral("\t");
            EndContext();
            BeginContext(222, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eecbcbe9c2dd4c8ba78abcaf8fb08acc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(250, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\Acer_Aspire\Desktop\Code_repo\shareABite2.0\ShareABite2\Views\Home\Index.cshtml"
}
else
{



#line default
#line hidden
            BeginContext(268, 1, true);
            WriteLiteral("\t");
            EndContext();
            BeginContext(269, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "308679f03551446189a6fa6175cbbf56", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(299, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(303, 1022, true);
            WriteLiteral(@"	<div class=""row"">
		<div class=""col-sm-12"">
			<h1>Saving Recipe Memories just got Easy</h1>
			<h3>The problem</h3>
			<p>
				Saving family recipes has always been a challenge. Massive binders, heavy boxes, and a seemingly endless supply of 3x5 cards with recipes that have been handed down for generations. You work to put them in a shared document in the cloud and publish lovingly crafted books to share with your family.
			</p>
			<p>
				While that effort is amazing and it takes wonderful people to do that type of work. However we can lose all of those recipes in an instant when nature takes it's course.
			</p>
			<h3>The solution</h3>
			<p>
				Instead of going through all that work time and time again. Save each recipe once and have access to it forever. Share a Bite carefully stores each recipe in the cloud and enables you to endlessly share the recipe with all of your family and friends. Say goodbye to reading old moldy notecards with hard-to-read recipes
			</p>
		</div>
	</div>
");
            EndContext();
            BeginContext(1327, 163, true);
            WriteLiteral("\t<div class=\"row\">\r\n\t\t<div class=\"col-sm-12\">\r\n\t\t\t<h2>Recipes Recently Saved</h2>\r\n\t\t\t<div id=\"recentCommunityRecipes\" class=\"row\">\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
            EndContext();
#line 42 "C:\Users\Acer_Aspire\Desktop\Code_repo\shareABite2.0\ShareABite2\Views\Home\Index.cshtml"



}

#line default
#line hidden
            BeginContext(1499, 34, true);
            WriteLiteral("\r\n<script>\r\n\r\n\r\n\tvar userIdNum = \'");
            EndContext();
            BeginContext(1534, 27, false);
#line 50 "C:\Users\Acer_Aspire\Desktop\Code_repo\shareABite2.0\ShareABite2\Views\Home\Index.cshtml"
                Write(UserManager.GetUserId(User));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 5159, true);
            WriteLiteral(@"'

	$(document).ready(function () {

		loadCommunityRecipes(12)

	})

	function loadCommunityRecipes(count) {
		var settings = {
			""async"": true,
			""crossDomain"": true,
			""url"": ""api/Recipe/MostRecentRecipes/""+count,
			""method"": ""GET"",
			""headers"": {
				""cache-control"": ""no-cache"",
			}
		}

		$.ajax(settings).done(function (response) {
			console.log(response);
			$(response).each(function (ind, val) {
				$('#recentCommunityRecipes').append('<div class=""col-sm-4 recipe""><h3>' + val.recipeName + '</h3>' +
					'<div class=""jumbotron"" style=""background-image: url(' + val.imgUrl + ')""></div>' +
					'<div class=""row recipe-Details"">' +
					'<div class=""col-sm-6 pull-left"">' + val.cookTime + "" Minutes"" + ""</div>"" +
					'<div class=""col-sm-6 pull-right"">' + val.servings + "" People"" + ""</div>"" +
					'</div>' +
					//display recipe desc
					'<h4>Description</h4>' +
					'<p class=""recipe-story"" data-RecipeId=""' + val.recipeId + '"">' +
					val.description +
					'</p>' +");
            WriteLiteral(@"
					//display view, edit, and share btns
					'<div class=""row recipe-footer"">' +
					'<div class=""col-sm-4 row recipe-footer-share"">' +
					//edit
					'<a class=""col-sm-6"" href=""/Recipe/Edit/' + val.recipeId + '"" target=""_blank"">' +
					'<span class=""glyphicon glyphicon-edit"" aria-hidden=""true""></span>' +
					'</a>' +
					//view recipe
					'<a class=""col-sm-6"" href=""/View/Recipe/' + val.recipeId + ' "" class="""">' +
					'<span class=""glyphicon glyphicon-eye-open"" aria-hidden=""true""></span>' +
					'</a>' +
					'</div>' +
					'<div class=""col-sm-4 recipe-footer-share"">' +
					//twitter share code
					'</div>' +
					'<div class=""col-sm-4 recipe-footer-share"">' +
					'<div class=""fb-share-button"" data-href=""https://shareabiteweb.azurewebsites.net/view/recipe/' + val.recipeId + '""data-layout=""button_count"">' +
					'</div>' +
					'</div>' +
					'</div>' +
					'</div>' +
					'</div>' +

					'</div>')

			})

		})
	}


	function loadUserRecipes(userIdNumber) {
		v");
            WriteLiteral(@"ar settings = {
			""async"": true,
			""crossDomain"": true,
			""url"": ""/Recipe/MyMostRecentRecipes?userInfo="" + userIdNumber,
			""method"": ""GET"",
			""headers"": {
				""cache-control"": ""no-cache"",
			}
		}

		$.ajax(settings).done(function (response) {
			console.log(response);
			$(response).each(function (ind, val) {
				$('#myRecentRecipes').append('<div class=""col-sm-4 recipe""><h3>' + val.recipeName + '</h3>' +
					'<div class=""jumbotron"" style=""background-image: url(' + val.imgUrl + ')""></div>' +
					'<div class=""row recipe-Details"">' +
					'<div class=""col-sm-6 pull-left"">' + val.cookTime + "" Minutes"" + ""</div>"" +
					'<div class=""col-sm-6 pull-right"">' + val.servings + "" People"" + ""</div>"" +
					'</div>' +
					//display recipe desc
					'<h4>Description</h4>' +
					'<p class=""recipe-story"" data-RecipeId=""' + val.recipeId + '"">' +
					val.description +
					'</p>' +
					//display view, edit, and share btns
					'<div class=""row recipe-footer"">' +
					'<div class=""col-sm-4");
            WriteLiteral(@" recipe-footer-share"">' +
					//edit
					'<a class=""col-sm-6"" href=""/Recipe/Edit/' + val.recipeId + '"" target=""_blank"">' +
					'<span class=""glyphicon glyphicon-edit"" aria-hidden=""true""></span>' +
					'</a>' +
					//view recipe
					'<a class=""col-sm-6"" href=""/View/Recipe/' + val.recipeId + ' "" class="""">' +
					'<span class=""glyphicon glyphicon-eye-open"" aria-hidden=""true""></span>' +
					'</a>' +
					'</div>' +

					'<div class=""col-sm-4 recipe-footer-share"">' +
					//twitter share code
					'</div>' +
					'<div class=""col-sm-4 recipe-footer-share"">' +
					'<div class=""fb-share-button"" data-href=""https://shareabiteweb.azurewebsites.net/view/recipe/' + val.recipeId + '""data-layout=""button_count"">' +
					'</div>' +
					'</div>' +
					'</div>' +
					'</div>' +
					'</div>' +

					'</div>')

			})
			readMoreDisplay()

		})
	}
	function countUserRecipes(userIdNumber) {
		var settings = {
			""async"": true,
			""crossDomain"": true,
			""url"": ""/Recipe/CountUserRecipe");
            WriteLiteral(@"s?userInfo="" + userIdNumber,
			""method"": ""GET"",
			""headers"": {
				""cache-control"": ""no-cache"",
			}
		}

		$.ajax(settings).done(function (response) {
			if (response == 1) {
				$('#userRecipeCount').html(""I have Preserved "" + response + "" Memory (Recipe)!"")
			} else if (response >= 25) {
				$('#userRecipeCount').html(""Holy cow, I have Preserved "" + response + "" Memories (Recipes)!"")
			} else if (response >= 50) {
				$('#userRecipeCount').html(""Wow! I have Preserved over 50 Memories (Recipes)!"")

			} else {
				$('#userRecipeCount').html(""I have Preserved "" + response + "" Memories (Recipes)!"")

			}
		})
	}

	function readMoreDisplay() {
		$('.recipe-story').each(function (ind, val) {
			let storyLength = $(val).html().length;
			let story = $(val).html();
			let RecipeId = $(val).attr('data-recipeid');
			if (storyLength > 200) {
				story = story.split(200);
				$(val).html(story + "" <a href='/view/recipe/"" + RecipeId + ""'>Read More...</a>"")
			} else {
				$(val).htm");
            WriteLiteral("l(story)\r\n\t\t\t}\r\n\t\t})\r\n\t}\r\n</script>\r\n\r\n");
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
