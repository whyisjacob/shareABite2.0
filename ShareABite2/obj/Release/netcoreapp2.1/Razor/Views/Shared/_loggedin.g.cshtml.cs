#pragma checksum "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Shared\_loggedin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "085e5ff1fdaf086d5128226e6790c6b2f8cc8374"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__loggedin), @"mvc.1.0.view", @"/Views/Shared/_loggedin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_loggedin.cshtml", typeof(AspNetCore.Views_Shared__loggedin))]
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
#line 1 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Shared\_loggedin.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"085e5ff1fdaf086d5128226e6790c6b2f8cc8374", @"/Views/Shared/_loggedin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30271edc521a734dba71f22becbc477cb261745", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__loggedin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(136, 417, true);
            WriteLiteral(@"<div id=""fb-root""></div>
<script>
	(function (d, s, id) {
		var js, fjs = d.getElementsByTagName(s)[0];
		if (d.getElementById(id)) return;
		js = d.createElement(s); js.id = id;
		js.src = ""https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v3.0"";
		fjs.parentNode.insertBefore(js, fjs);
	}(document, 'script', 'facebook-jssdk'));</script>

<div class=""row"">
	<div class=""col-sm-8"">
		<h1>Welcome ");
            EndContext();
            BeginContext(554, 29, false);
#line 16 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Shared\_loggedin.cshtml"
               Write(UserManager.GetUserName(User));

#line default
#line hidden
            EndContext();
            BeginContext(583, 2684, true);
            WriteLiteral(@"!</h1>
		<h4>Memories (Recipes) Preserved 12</h4>
		<a href=""#"" class=""btn btn-primary"">Save a New Recipe</a>
	</div>
	<div class=""col-sm-4"">

	</div>
</div>
<div class=""row"">
	<div class=""col-sm-12"">
		<h2>Recently Added Recipes</h2>
		<div id=""recentRecipes"" class=""row"">
		</div>
	</div>
</div>

<script>
	var settings = {
		""async"": true,
		""crossDomain"": true,
		""url"": ""/Recipe/MostRecentRecipes"",
		""method"": ""GET"",
		""headers"": {
			""cache-control"": ""no-cache"",
			""Postman-Token"": ""a1cf4227-de5c-4350-9403-f1b937fee072""
		}
	}

	$.ajax(settings).done(function (response) {
		console.log(response);
		$(response).each(function (ind, val) {
			$('#recentRecipes').append('<div class=""col-sm-4 recipe""><h3>' + val.recipeName + '</h3>' +
				'<div class=""jumbotron"" style=""background-image: url(' + val.imgUrl + ')""></div>' +
				'<div class=""row recipe-Details"">' +
					'<div class=""col-sm-6 pull-left"">' + val.cookTime + "" Minutes"" + ""</div>"" +
					'<div class=""col-sm-6 pull-righ");
            WriteLiteral(@"t"">' + val.servings + "" People"" + ""</div>"" +
				'</div>' +
				//display recipe desc
				'<h4>Description</h4>' +
				'<p class=""recipe-story"" data-RecipeId=""' + val.recipeId + '"">' +
				val.description +
				'</p>' +
				//display view, edit, and share btns
				'<div class=""row recipe-footer"">' +
					'<div class=""col-sm-4 recipe-footer-share"">' +
						//edit
						'<a href=""/Recipe/Edit/' + val.recipeId + '"" target=""_blank"">' +
						'<span class=""glyphicon glyphicon-edit"" aria-hidden=""true""></span>' +
						'</a>' +
						//view recipe
						'<a href=""/View/Recipe/' + val.recipeId + ' "" class="""">' +
						'<span class=""glyphicon glyphicon-eye-open"" aria-hidden=""true""></span>' +
						'</a>' +
						'<div class=""col-sm-4 recipe-footer-share"">' +
						//twitter share code
						'</div>' +
						'<div class=""col-sm-4 recipe-footer-share"">' +
							'<div class=""fb-share-button"" data-href=""https://shareabiteweb.azurewebsites.net/view/recipe/' + val.recipeId + '""data-layout=""button_cou");
            WriteLiteral(@"nt"">' +
							'</div>' +
						'</div>' +
					'</div>' +
				'</div>' +
				'</div>' +

				'</div>')

		})
	})

	$(document).ready(function () {

		readMoreDisplay()
	})

	function readMoreDisplay() {
		$('.recipe-story').each(function (ind, val) {
			let storyLength = $(val).html().length;
			let story = $(val).html();
			let RecipeId = $(val).attr('data-recipeid');
			console.log(RecipeId)
			if (storyLength > 200) {
				story = story.split(200);
				$(val).html(story + "" <a href='/Recipe/Details/"" + RecipeId + ""'>Read More...</a>"")
			} else {
				$(val).html(story)
			}
		})
	}
</script>

");
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
