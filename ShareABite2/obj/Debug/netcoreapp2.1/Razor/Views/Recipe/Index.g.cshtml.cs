#pragma checksum "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9117e61a729fcba49f5b87d9c70dacd81753b52b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_Index), @"mvc.1.0.view", @"/Views/Recipe/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipe/Index.cshtml", typeof(AspNetCore.Views_Recipe_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9117e61a729fcba49f5b87d9c70dacd81753b52b", @"/Views/Recipe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30271edc521a734dba71f22becbc477cb261745", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShareABite2.Models.RecipeModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DataTables/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
  
	ViewData["Title"] = "Recipes";

#line default
#line hidden
            BeginContext(94, 520, true);
            WriteLiteral(@"<div id=""fb-root""></div>
<script>
	(function (d, s, id) {
		var js, fjs = d.getElementsByTagName(s)[0];
		if (d.getElementById(id)) return;
		js = d.createElement(s); js.id = id;
		js.src = ""https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v3.0"";
		fjs.parentNode.insertBefore(js, fjs);
	}(document, 'script', 'facebook-jssdk'));</script>


<h2>My Recipes</h2>
<p>
	Your favorite recipes are an integral part of your family. Below is a list of your added family recipes
</p>

<div class=""row"">
");
            EndContext();
#line 23 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
     foreach (var item in Model)
	{


#line default
#line hidden
            BeginContext(651, 43, true);
            WriteLiteral("\t<div class=\"col-sm-4 recipe\">\r\n\t\t<h3>\r\n\t\t\t");
            EndContext();
            BeginContext(695, 45, false);
#line 28 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.RecipeName));

#line default
#line hidden
            EndContext();
            BeginContext(740, 35, true);
            WriteLiteral("\r\n\t\t</h3>\r\n\t\t<div class=\"jumbotron\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 775, "\"", 848, 4);
            WriteAttributeValue("", 783, "background-image:", 783, 17, true);
            WriteAttributeValue(" ", 800, "url(", 801, 5, true);
#line 30 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
WriteAttributeValue("", 805, Html.DisplayFor(modelItem => item.ImgUrl), 805, 42, false);

#line default
#line hidden
            WriteAttributeValue("", 847, ")", 847, 1, true);
            EndWriteAttribute();
            BeginContext(849, 90, true);
            WriteLiteral(">\r\n\t\t</div>\r\n\t\t<div class=\"row recipe-Details\">\r\n\t\t\t<div class=\"col-sm-6 pull-left\">\r\n\t\t\t\t");
            EndContext();
            BeginContext(940, 43, false);
#line 34 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CookTime));

#line default
#line hidden
            EndContext();
            BeginContext(983, 63, true);
            WriteLiteral(" Minutes\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-sm-6 pull-right\">\r\n\t\t\t\t");
            EndContext();
            BeginContext(1047, 43, false);
#line 37 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Servings));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 30, true);
            WriteLiteral(" People\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
            EndContext();
#line 40 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
         if (!String.IsNullOrEmpty(item.Story))
		{

#line default
#line hidden
            BeginContext(1168, 59, true);
            WriteLiteral("\t\t<h4>Story</h4>\r\n\t\t<p class=\"recipe-story\" data-RecipeId=\"");
            EndContext();
            BeginContext(1228, 13, false);
#line 43 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
                                          Write(item.RecipeId);

#line default
#line hidden
            EndContext();
            BeginContext(1241, 7, true);
            WriteLiteral("\">\r\n\t\t\t");
            EndContext();
            BeginContext(1249, 40, false);
#line 44 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Story));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 10, true);
            WriteLiteral("\r\n\t\t</p>\r\n");
            EndContext();
#line 46 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
		} else {

#line default
#line hidden
            BeginContext(1311, 65, true);
            WriteLiteral("\t\t<h4>Description</h4>\r\n\t\t<p class=\"recipe-story\" data-RecipeId=\"");
            EndContext();
            BeginContext(1377, 13, false);
#line 48 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
                                          Write(item.RecipeId);

#line default
#line hidden
            EndContext();
            BeginContext(1390, 7, true);
            WriteLiteral("\">\r\n\t\t\t");
            EndContext();
            BeginContext(1398, 46, false);
#line 49 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 10, true);
            WriteLiteral("\r\n\t\t</p>\r\n");
            EndContext();
#line 51 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(1459, 110, true);
            WriteLiteral("\r\n\t\t<div class=\"row recipe-footer\">\r\n\t\t\t<div class=\"col-sm-4 recipe-footer-share\">\r\n\t\t\t\t<!--View/Edit-->\r\n\t\t\t\t");
            EndContext();
            BeginContext(1569, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3aca567f7974e38aea8b6036988bb9e", async() => {
                BeginContext(1629, 78, true);
                WriteLiteral("\r\n\t\t\t\t\t<span class=\"glyphicon glyphicon-edit\" aria-hidden=\"true\"></span>\r\n\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
                                       WriteLiteral(item.RecipeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1711, 8, true);
            WriteLiteral("\r\n\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1719, "\"", 1753, 2);
            WriteAttributeValue("", 1726, "/View/Recipe/", 1726, 13, true);
#line 59 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
WriteAttributeValue("", 1739, item.RecipeId, 1739, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1754, 377, true);
            WriteLiteral(@" class="""">
					<span class=""glyphicon glyphicon-eye-open"" aria-hidden=""true""></span>
				</a>
			</div>
			<div class=""col-sm-4 recipe-footer-share"">
				<!--Twitter-->
			</div>
			<div class=""col-sm-4 recipe-footer-share"">
				<!-- Your share button code -->
				<div class=""fb-share-button""
					 data-href=""https://shareabiteweb.azurewebsites.net/Recipe/Details/");
            EndContext();
            BeginContext(2132, 13, false);
#line 69 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
                                                                                  Write(item.RecipeId);

#line default
#line hidden
            EndContext();
            BeginContext(2145, 80, true);
            WriteLiteral("\"\r\n\t\t\t\t\t data-layout=\"button_count\">\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
            EndContext();
#line 75 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Recipe\Index.cshtml"
	}

#line default
#line hidden
            BeginContext(2229, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(2239, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "663727281dd24113b61b8b8afefa0a59", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2296, 518, true);
            WriteLiteral(@"

<script>
	$(document).ready(function () {

		readMoreDisplay()
	})

	function readMoreDisplay() {
		$('.recipe-story').each(function (ind,val) {
			let storyLength = $(val).html().length;
			let story = $(val).html();
			let RecipeId = $(val).attr('data-recipeid');
			console.log(RecipeId)
			if (storyLength > 200) {
				story = story.split(200);
				$(val).html(story + "" <a href='/Recipe/Details/"" + RecipeId+""'>Read More...</a>"")
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShareABite2.Models.RecipeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
