#pragma checksum "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Shared\_loggedin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cff31a61a6eed48625bb8424ea276c397216beaa"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cff31a61a6eed48625bb8424ea276c397216beaa", @"/Views/Shared/_loggedin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30271edc521a734dba71f22becbc477cb261745", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__loggedin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_HeroSlider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(136, 393, true);
            WriteLiteral(@"
<div id=""fb-root""></div>
<script>
	(function (d, s, id) {
		var js, fjs = d.getElementsByTagName(s)[0];
		if (d.getElementById(id)) return;
		js = d.createElement(s); js.id = id;
		js.src = ""https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v3.0"";
		fjs.parentNode.insertBefore(js, fjs);
	}(document, 'script', 'facebook-jssdk'));</script>

<div class=""row"">
	<h1>Welcome ");
            EndContext();
            BeginContext(530, 29, false);
#line 16 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Shared\_loggedin.cshtml"
           Write(UserManager.GetUserName(User));

#line default
#line hidden
            EndContext();
            BeginContext(559, 418, true);
            WriteLiteral(@"! </h1>

	<div class=""col-sm-12"">
		<p>We are glad you have decided to join in the effort of preserving your recipes and sharing them with others. We hope you enjoy saving your favorite recipes. Should you encounter any challenges please <a href=""#"">Reach out to us</a> and we will take care of you.</p>

			<h4><span id=""userRecipeCount""></span></h4>

		</div>
	<div class=""col-sm-12 "">

	</div>
</div>

");
            EndContext();
            BeginContext(977, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e86f547a43e14393a5bc260a76ca0f9f", async() => {
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
            BeginContext(1007, 340, true);
            WriteLiteral(@"

<div class=""row"">
	<div class=""col-sm-12"">
		<h2>My Recent Recipes</h2>
		<div id=""myRecentRecipes"" class=""row"">
		</div>
	</div>
</div>
<div class=""row"">
	<div class=""col-sm-12"">
		<h2>Recent Community Recipes</h2>
		<div id=""recentCommunityRecipes"" class=""row"">
		</div>
	</div>
</div>

<script>


	var userIdNum = '");
            EndContext();
            BeginContext(1348, 27, false);
#line 49 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Shared\_loggedin.cshtml"
                Write(UserManager.GetUserId(User));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 5205, true);
            WriteLiteral(@"'

	$(document).ready(function () {

		loadCommunityRecipes()
		loadUserRecipes(userIdNum)
		countUserRecipes(userIdNum);

	})

	function loadCommunityRecipes() {
		var settings = {
			""async"": true,
			""crossDomain"": true,
			""url"": ""/Recipe/MostRecentRecipes"",
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
					'<p class=""recipe-story"" data-RecipeId=""' + val.recipeId + '");
            WriteLiteral(@""">' +
					val.description +
					'</p>' +
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


	");
            WriteLiteral(@"function loadUserRecipes(userIdNumber) {
		var settings = {
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
					'<div class=""row r");
            WriteLiteral(@"ecipe-footer"">' +
					'<div class=""col-sm-4 recipe-footer-share"">' +
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
			""crossDomai");
            WriteLiteral(@"n"": true,
			""url"": ""/Recipe/CountUserRecipes?userInfo="" + userIdNumber,
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
				$(val).html(story + "" <a href='/view/recipe/"" + RecipeId + ""'>Re");
            WriteLiteral("ad More...</a>\")\r\n\t\t\t} else {\r\n\t\t\t\t$(val).html(story)\r\n\t\t\t}\r\n\t\t})\r\n\t}\r\n</script>\r\n\r\n ");
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