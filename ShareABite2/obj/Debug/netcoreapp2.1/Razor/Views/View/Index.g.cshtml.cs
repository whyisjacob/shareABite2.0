#pragma checksum "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87f098c57b0e951470f664ad9f3750df2004d04c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_View_Index), @"mvc.1.0.view", @"/Views/View/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/View/Index.cshtml", typeof(AspNetCore.Views_View_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87f098c57b0e951470f664ad9f3750df2004d04c", @"/Views/View/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30271edc521a734dba71f22becbc477cb261745", @"/Views/_ViewImports.cshtml")]
    public class Views_View_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShareABite2.Models.RecipeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 125, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>RecipeModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(210, 46, false);
#line 14 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.RecipeName));

#line default
#line hidden
            EndContext();
            BeginContext(256, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(300, 42, false);
#line 17 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.RecipeName));

#line default
#line hidden
            EndContext();
            BeginContext(342, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(386, 45, false);
#line 20 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(431, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(475, 41, false);
#line 23 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(516, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(560, 46, false);
#line 26 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.DateEdited));

#line default
#line hidden
            EndContext();
            BeginContext(606, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(650, 42, false);
#line 29 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.DateEdited));

#line default
#line hidden
            EndContext();
            BeginContext(692, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(736, 41, false);
#line 32 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Story));

#line default
#line hidden
            EndContext();
            BeginContext(777, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(821, 37, false);
#line 35 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.Story));

#line default
#line hidden
            EndContext();
            BeginContext(858, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(902, 47, false);
#line 38 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(949, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(993, 43, false);
#line 41 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1080, 42, false);
#line 44 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ImgUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1166, 38, false);
#line 47 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.ImgUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1204, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1248, 44, false);
#line 50 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.OvenTemp));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1336, 40, false);
#line 53 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.OvenTemp));

#line default
#line hidden
            EndContext();
            BeginContext(1376, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1420, 44, false);
#line 56 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Servings));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1508, 40, false);
#line 59 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.Servings));

#line default
#line hidden
            EndContext();
            BeginContext(1548, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1592, 44, false);
#line 62 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PrepTime));

#line default
#line hidden
            EndContext();
            BeginContext(1636, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1680, 40, false);
#line 65 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.PrepTime));

#line default
#line hidden
            EndContext();
            BeginContext(1720, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1764, 44, false);
#line 68 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.CookTime));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1852, 40, false);
#line 71 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.CookTime));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1936, 42, false);
#line 74 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Public));

#line default
#line hidden
            EndContext();
            BeginContext(1978, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2022, 38, false);
#line 77 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.Public));

#line default
#line hidden
            EndContext();
            BeginContext(2060, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2104, 51, false);
#line 80 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.IngredientsJson));

#line default
#line hidden
            EndContext();
            BeginContext(2155, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2199, 47, false);
#line 83 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.IngredientsJson));

#line default
#line hidden
            EndContext();
            BeginContext(2246, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2290, 50, false);
#line 86 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.DirectionsJson));

#line default
#line hidden
            EndContext();
            BeginContext(2340, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2384, 46, false);
#line 89 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.DirectionsJson));

#line default
#line hidden
            EndContext();
            BeginContext(2430, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2474, 42, false);
#line 92 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(2516, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2560, 38, false);
#line 95 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\View\Index.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(2598, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2645, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e300ac72fd804fdf811edc8bbdaf6295", async() => {
                BeginContext(2667, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2683, 10, true);
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