#pragma checksum "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc781ead1a0c6326b1caf8765a440fcd115ce9c8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc781ead1a0c6326b1caf8765a440fcd115ce9c8", @"/Views/View/Recipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30271edc521a734dba71f22becbc477cb261745", @"/Views/_ViewImports.cshtml")]
    public class Views_View_Recipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShareABite2.Models.RecipeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Timeago/Timeago.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
  
	ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(81, 147, true);
            WriteLiteral("\r\n\r\n\t<div class=\"container r-container\">\r\n\t\t<article class=\"col-md-10\">\r\n\t\t\t<section class=\'recipe\'>\r\n\t\t\t\t<h2 id=\"recipe_name\" class=\"recipe_name\">");
            EndContext();
            BeginContext(229, 42, false);
#line 11 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                                                    Write(Html.DisplayFor(model => model.RecipeName));

#line default
#line hidden
            EndContext();
            BeginContext(271, 49, true);
            WriteLiteral("</h2>\r\n\t\t\t\t<h3>\r\n\t\t\t\t\tAdded By: <span id=\"addby\">");
            EndContext();
            BeginContext(321, 38, false);
#line 13 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                                          Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(359, 41, true);
            WriteLiteral("</span>,\r\n\t\t\t\t\t<time class=\"time timeago\"");
            EndContext();
            BeginWriteAttribute("datetime", " datetime=\"", 400, "\"", 454, 1);
#line 14 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
WriteAttributeValue("", 411, Html.DisplayFor(model => model.DateEdited), 411, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(455, 284, true);
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
            BeginWriteAttribute("style", " style=\"", 739, "\"", 812, 4);
            WriteAttributeValue("", 747, "background-image:", 747, 17, true);
            WriteAttributeValue(" ", 764, "url=(\'", 765, 7, true);
#line 24 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
WriteAttributeValue("", 771, Html.DisplayFor(model => model.ImgUrl), 771, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 810, "\')", 810, 2, true);
            EndWriteAttribute();
            BeginContext(813, 313, true);
            WriteLiteral(@">
					<!-- <img class=""recipe_image"" src=""assets/img/chicken-fajita.jpg"" alt""bla bla""> -->
				</div>
			</section>

			<section>
				<h4 data-display=""show"">
					The Story <span class=""glyphicon glyphicon-menu-down"" aria-hidden=""true""></span>
				</h4>
				<div id=""story"" class=""description "">
					");
            EndContext();
            BeginContext(1127, 37, false);
#line 34 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
               Write(Html.DisplayFor(model => model.Story));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 18, true);
            WriteLiteral("\r\n\t\t\t\t\t<br>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1183, 43, false);
#line 36 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 735, true);
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
				<div id=""directions"" class=""directions hidden"">
					<div class=""disp row"">
						<div class=""display col-xs-4"">
							<img src=""assets/img/oven.png"" alt=""Oven Temperature"" class=""directions_image""><br>
																										   <span id=""oven"" class=""directions_display"">");
            EndContext();
            BeginContext(1962, 40, false);
#line 58 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                                                                                                                                                 Write(Html.DisplayFor(model => model.OvenTemp));

#line default
#line hidden
            EndContext();
            BeginContext(2002, 238, true);
            WriteLiteral("˚</span>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<div class=\"display col-xs-4\">\r\n\t\t\t\t\t\t\t<img src=\"assets/img/clock.png\" alt=\"Total Prep and Cook Time\" class=\"directions_image\"><br>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span id=\"clock\" class=\"directions_display\">");
            EndContext();
            BeginContext(2241, 40, false);
#line 63 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                                                                                                                                                           Write(Html.DisplayFor(model => model.CookTime));

#line default
#line hidden
            EndContext();
            BeginContext(2281, 226, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<div class=\"display col-xs-4\">\r\n\t\t\t\t\t\t\t<img src=\"assets/img/servings.png\" alt=\"Servings\" class=\"directions_image\"><br>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t   <span id=\"Servings\" class=\"directions_display\">");
            EndContext();
            BeginContext(2508, 40, false);
#line 68 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                                                                                                                                                 Write(Html.DisplayFor(model => model.Servings));

#line default
#line hidden
            EndContext();
            BeginContext(2548, 79, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div id=\'steps\' class=\"steps\">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(2628, 46, false);
#line 72 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                   Write(Html.DisplayFor(model => model.DirectionsJson));

#line default
#line hidden
            EndContext();
            BeginContext(2674, 766, true);
            WriteLiteral(@"
					</div>
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

	<footer id=""footer"" class=""footer"">
		<hr> © 2017 Share a Bite, Inc. All Rights reserved.
		<a href=""#"">Privacy Policy</a> |
		<a href=""#"">Terms of Use</a> <br><br>
	</footer>


	");
            EndContext();
            BeginContext(3440, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a4e5efed76b4dbf8bb4f9e688a9864c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 97 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
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
            BeginContext(3513, 114, true);
            WriteLiteral("\r\n\r\n\t<script>\r\n\t\t$(document).ready(function () {\r\n\r\n\t\t\t\t\t$(\'.recipe_image\').css({\r\n\t\t\t\t\t\t\'background-image\': \'url(");
            EndContext();
            BeginContext(3628, 38, false);
#line 103 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                                            Write(Html.DisplayFor(model => model.ImgUrl));

#line default
#line hidden
            EndContext();
            BeginContext(3666, 68, true);
            WriteLiteral(")\'\r\n\t\t\t\t\t});\r\n\r\n\r\n\t\t\t\t\t//display ingredients\r\n\t\t\tvar ingredients = \"");
            EndContext();
            BeginContext(3735, 47, false);
#line 108 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
                          Write(Html.DisplayFor(model => model.IngredientsJson));

#line default
#line hidden
            EndContext();
            BeginContext(3782, 1016, true);
            WriteLiteral(@""";
			ingredients = ingredients.split("","");
					var ing = 1;
					ingredients.forEach(function (ingr) {
						// console.log(ingr);
						$('#ingredients_list').append(
							'<li class=""ing_display""> <span class="" glyphicon glyphicon-remove-circle""></span> ' + ingr + '</li>');
						ing++
					})


					if (v.oTemp == '0') {
						$('#oven').html('Not Needed');
					} else {
						$('#oven').html(v.oTemp + '&#730;');
					}
					$('#clock').html(v.rTime + ' Min');
					$('#servings').html(v.rServings)

					//display all directions
					var steps = v.rDirections
					var st = 1;
					steps.forEach(function (theSteps) {
						// console.log(theSteps);
						$('#steps').append('<h5>Step ' + st + '</h5><p>' + theSteps + '</p>');
						st++
					})

					jQuery(""time.timeago"").timeago();

		});

	</script>

	<script src=""assets/js/app.js""></script>


<h2>Details</h2>

<div>
	<h4>RecipeModel</h4>
	<hr />
	<dl class=""dl-horizontal"">
		<dt>
			</dd>
		<dt>
			");
            EndContext();
            BeginContext(4799, 45, false);
#line 154 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayNameFor(model => model.DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(4844, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(4867, 41, false);
#line 157 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayFor(model => model.DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(4908, 41, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(4950, 42, false);
#line 163 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayFor(model => model.DateEdited));

#line default
#line hidden
            EndContext();
            BeginContext(4992, 41, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(5034, 37, false);
#line 169 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayFor(model => model.Story));

#line default
#line hidden
            EndContext();
            BeginContext(5071, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(5094, 47, false);
#line 172 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(5141, 39, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(5181, 42, false);
#line 177 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayNameFor(model => model.ImgUrl));

#line default
#line hidden
            EndContext();
            BeginContext(5223, 41, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(5265, 44, false);
#line 183 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayNameFor(model => model.OvenTemp));

#line default
#line hidden
            EndContext();
            BeginContext(5309, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(5332, 40, false);
#line 186 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayFor(model => model.OvenTemp));

#line default
#line hidden
            EndContext();
            BeginContext(5372, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(5395, 44, false);
#line 189 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayNameFor(model => model.Servings));

#line default
#line hidden
            EndContext();
            BeginContext(5439, 44, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(5484, 44, false);
#line 195 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayNameFor(model => model.PrepTime));

#line default
#line hidden
            EndContext();
            BeginContext(5528, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(5551, 40, false);
#line 198 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayFor(model => model.PrepTime));

#line default
#line hidden
            EndContext();
            BeginContext(5591, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(5614, 44, false);
#line 201 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayNameFor(model => model.CookTime));

#line default
#line hidden
            EndContext();
            BeginContext(5658, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(5681, 40, false);
#line 204 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayFor(model => model.CookTime));

#line default
#line hidden
            EndContext();
            BeginContext(5721, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(5744, 42, false);
#line 207 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayNameFor(model => model.Public));

#line default
#line hidden
            EndContext();
            BeginContext(5786, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(5809, 38, false);
#line 210 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayFor(model => model.Public));

#line default
#line hidden
            EndContext();
            BeginContext(5847, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(5870, 51, false);
#line 213 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayNameFor(model => model.IngredientsJson));

#line default
#line hidden
            EndContext();
            BeginContext(5921, 44, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(5966, 50, false);
#line 219 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayNameFor(model => model.DirectionsJson));

#line default
#line hidden
            EndContext();
            BeginContext(6016, 44, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(6061, 42, false);
#line 225 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(6103, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(6126, 38, false);
#line 228 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Recipe.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(6164, 35, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t</dl>\r\n</div>\r\n<div>\r\n\t");
            EndContext();
            BeginContext(6199, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dfd6ba9eaa46b38c4546acf5e99ba7", async() => {
                BeginContext(6221, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6237, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
