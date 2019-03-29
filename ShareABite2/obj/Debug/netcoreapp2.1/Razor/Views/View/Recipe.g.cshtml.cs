#pragma checksum "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f932a4b82eb99f815cd30ce605dda96b2988c665"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_View_Recipe), @"mvc.1.0.view", @"/Views/View/Recipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/View/Recipe.cshtml", typeof(AspNetCore.Views_View_Recipe))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f932a4b82eb99f815cd30ce605dda96b2988c665", @"/Views/View/Recipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30271edc521a734dba71f22becbc477cb261745", @"/Views/_ViewImports.cshtml")]
    public class Views_View_Recipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShareABite2.Models.RecipeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/oven.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Oven Temperature"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("directions_image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/clock.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Total Prep and Cook Time"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/servings.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Servings"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Timeago/Timeago.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
  
	var title = @Html.DisplayFor(model => model.RecipeName);
	ViewData["Title"] = title;
	var description = @Html.DisplayFor(model => model.Story);
	ViewData["Description"] = description;
	var imageURL = Html.DisplayFor(model => model.ImgUrl);
	ViewData["imageURL"] = imageURL;

#line default
#line hidden
            BeginContext(329, 143, true);
            WriteLiteral("\r\n\r\n<div class=\"container r-container\">\r\n\t<article class=\"col-md-10\">\r\n\t\t<section class=\'recipe\'>\r\n\t\t\t<h2 id=\"recipe_name\" class=\"recipe_name\">");
            EndContext();
            BeginContext(473, 42, false);
#line 16 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                                                Write(Html.DisplayFor(model => model.RecipeName));

#line default
#line hidden
            EndContext();
            BeginContext(515, 47, true);
            WriteLiteral("</h2>\r\n\t\t\t<h3>\r\n\t\t\t\tAdded By: <span id=\"addby\">");
            EndContext();
            BeginContext(563, 38, false);
#line 18 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                                      Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(601, 40, true);
            WriteLiteral("</span>,\r\n\t\t\t\t<time class=\"time timeago\"");
            EndContext();
            BeginWriteAttribute("datetime", " datetime=\"", 641, "\"", 695, 1);
#line 19 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
WriteAttributeValue("", 652, Html.DisplayFor(model => model.DateEdited), 652, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(696, 276, true);
            WriteLiteral(@"></time>
			</h3>
		</section>

		<section id=""categories"" class=""categories hidden"">
			This would be perfect for &nbsp;
			<a href=""#"">Breakfast</a> <a href=""#"">Lunch</a> <a href=""#"">Dinner</a>
		</section>

		<section class=""img_des"">
			<div class=""recipe_image""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 972, "\"", 1045, 4);
            WriteAttributeValue("", 980, "background-image:", 980, 17, true);
            WriteAttributeValue(" ", 997, "url=(\'", 998, 7, true);
#line 29 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
WriteAttributeValue("", 1004, Html.DisplayFor(model => model.ImgUrl), 1004, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 1043, "\')", 1043, 2, true);
            EndWriteAttribute();
            BeginContext(1046, 316, true);
            WriteLiteral(@">
				<!-- <img class=""recipe_image"" src=""assets/img/chicken-fajita.jpg"" alt""bla bla""> -->
			</div>
		</section>
		<section id=""StoryDisplay"">
			<h4 data-display=""show"">
				Story <span class=""glyphicon glyphicon-menu-down"" aria-hidden=""true""></span>
			</h4>
			<div id=""story"" class=""description "">
				");
            EndContext();
            BeginContext(1363, 37, false);
#line 38 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
           Write(Html.DisplayFor(model => model.Story));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 223, true);
            WriteLiteral("\r\n\r\n\t\t\t</div>\r\n\t\t</section>\r\n\r\n\t\t<section>\r\n\t\t\t<h4 data-display=\"show\">\r\n\t\t\t\tDescription <span class=\"glyphicon glyphicon-menu-down\" aria-hidden=\"true\"></span>\r\n\t\t\t</h4>\r\n\t\t\t<div id=\"description\" class=\"description \">\r\n\t\t\t\t");
            EndContext();
            BeginContext(1624, 43, false);
#line 48 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1667, 551, true);
            WriteLiteral(@"
			</div>
		</section>

		<section>
			<h4 data-display=""hidden"">
				Ingredients <span class=""glyphicon glyphicon-menu-right"" aria-hidden=""true""></span>
			</h4>
			<div id=""ingredients"" class=""ingredients "">
				<ul id=""ingredients_list""></ul>
			</div>
		</section>

		<section>
			<h4 data-display=""hidden"">
				Put it all together <span class=""glyphicon glyphicon-menu-right"" aria-hidden=""true""></span>
			</h4>
			<div id=""directions"" class=""directions"">
				<div class=""disp row"">
					<div class=""display col-xs-4"">
						");
            EndContext();
            BeginContext(2218, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a2b5b5a5ca6249999dfecc234d77a86c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2295, 55, true);
            WriteLiteral("<br>\r\n\t\t\t\t\t\t<span id=\"oven\" class=\"directions_display\">");
            EndContext();
            BeginContext(2351, 40, false);
#line 69 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                                                              Write(Html.DisplayFor(model => model.OvenTemp));

#line default
#line hidden
            EndContext();
            BeginContext(2391, 68, true);
            WriteLiteral("˚</span>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<div class=\"display col-xs-4\">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(2459, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b3293d292b0d4b439362adfe2fdb8c79", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2545, 56, true);
            WriteLiteral("<br>\r\n\t\t\t\t\t\t<span id=\"clock\" class=\"directions_display\">");
            EndContext();
            BeginContext(2602, 40, false);
#line 74 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                                                               Write(Html.DisplayFor(model => model.CookTime));

#line default
#line hidden
            EndContext();
            BeginContext(2642, 75, true);
            WriteLiteral(" minutes</span>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<div class=\"display col-xs-4\">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(2717, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1f79450a9d0487fa91f30aac36941ce", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2790, 59, true);
            WriteLiteral("<br>\r\n\t\t\t\t\t\t<span id=\"Servings\" class=\"directions_display\">");
            EndContext();
            BeginContext(2850, 40, false);
#line 79 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                                                                  Write(Html.DisplayFor(model => model.Servings));

#line default
#line hidden
            EndContext();
            BeginContext(2890, 70, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div id=\'steps\' class=\"steps\">\r\n");
            EndContext();
            BeginContext(2986, 567, true);
            WriteLiteral(@"				</div>
			</div>
		</section>

	</article>

	<!--Add display on medium and large screen-->
	<aside class=""col-md-2 hidden-xs hidden-sm hidden-print visible-md-block visible-lg-block"">
		<script async src=""https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js""></script>
		<!-- Grab A Bite -->
		<ins class=""adsbygoogle"" style=""display:block"" data-ad-client=""ca-pub-7521264905632007"" data-ad-slot=""3529081166"" data-ad-format=""auto""></ins>
		<script>
			(adsbygoogle = window.adsbygoogle || []).push({});
		</script>
	</aside>
</div>



");
            EndContext();
            BeginContext(3553, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "102a55087d704a3a8977ad252fa9c0f4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 103 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3626, 35, true);
            WriteLiteral("\r\n\r\n<script>\r\n\t\tlet recipeStory = \'");
            EndContext();
            BeginContext(3662, 37, false);
#line 106 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                      Write(Html.DisplayFor(model => model.Story));

#line default
#line hidden
            EndContext();
            BeginContext(3699, 99, true);
            WriteLiteral("\';\r\n\t\t$(document).ready(function () {\r\n\r\n\t\t\t$(\'.recipe_image\').css({\r\n\t\t\t\t\'background-image\': \'url(");
            EndContext();
            BeginContext(3799, 38, false);
#line 110 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                                    Write(Html.DisplayFor(model => model.ImgUrl));

#line default
#line hidden
            EndContext();
            BeginContext(3837, 164, true);
            WriteLiteral(")\'\r\n\t\t\t});\r\n\r\n\t\t\tconsole.log(recipeStory)\r\n\t\t\tif (recipeStory == \"\") {\r\n\t\t\t\t$(\'#StoryDisplay\').hide();\r\n\t\t\t}\r\n\r\n\r\n\t\t\t\t\t//display ingredients\r\n\t\t\tvar ingredients = \"");
            EndContext();
            BeginContext(4002, 47, false);
#line 120 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                          Write(Html.DisplayFor(model => model.IngredientsJson));

#line default
#line hidden
            EndContext();
            BeginContext(4049, 591, true);
            WriteLiteral(@""";
			ingredients = ingredients.split("","");
					var ing = 1;
					ingredients.forEach(function (ingr) {
						// console.log(ingr);
						$('#ingredients_list').append(
							'<li class=""ing_display""> <span class="" glyphicon glyphicon-remove-circle""></span> ' + ingr + '</li>');
						ing++
					})


					//if (v.oTemp == '0') {
					//	$('#oven').html('Not Needed');
					//} else {
					//	$('#oven').html(v.oTemp + '&#730;');
					//}
					//$('#clock').html(v.rTime + ' Min');
					//$('#servings').html(v.rServings)

					//display all directions
			var steps = """);
            EndContext();
            BeginContext(4641, 46, false);
#line 140 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                    Write(Html.DisplayFor(model => model.DirectionsJson));

#line default
#line hidden
            EndContext();
            BeginContext(4687, 286, true);
            WriteLiteral(@"""
			steps = steps.split("","");

				var st = 1;
				steps.forEach(function (theSteps) {
					// console.log(theSteps);
					$('#steps').append('<h5>Step ' + st + '</h5><p>' + theSteps + '</p>');
					st++
				})

				jQuery(""time.timeago"").timeago();

		});

</script>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShareABite2.Models.RecipeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
