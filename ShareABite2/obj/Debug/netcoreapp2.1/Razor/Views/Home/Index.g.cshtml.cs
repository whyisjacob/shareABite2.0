#pragma checksum "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a914e0570ae2e5b3348e318711a22ecdc49c0dd6"
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
#line 1 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\_ViewImports.cshtml"
using ShareABite2;

#line default
#line hidden
#line 2 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\_ViewImports.cshtml"
using ShareABite2.Models;

#line default
#line hidden
#line 1 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a914e0570ae2e5b3348e318711a22ecdc49c0dd6", @"/Views/Home/Index.cshtml")]
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
#line 5 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
#line 8 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Home\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
            BeginContext(221, 1, true);
            WriteLiteral("\t");
            EndContext();
            BeginContext(222, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9657f73b8cb34984aa5f9d1867338dc5", async() => {
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
#line 11 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Home\Index.cshtml"
}
else
{



#line default
#line hidden
            BeginContext(268, 1, true);
            WriteLiteral("\t");
            EndContext();
            BeginContext(269, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bca8c6e97e04493ba7ac4b307262c87e", async() => {
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
            BeginContext(305, 2117, true);
            WriteLiteral(@"	<div class=""row"">
		<div class=""col-md-3"">
			<h2>Application uses</h2>
			<ul>
				<li>Sample pages using ASP.NET Core MVC</li>
				<li>Theming using <a href=""https://go.microsoft.com/fwlink/?LinkID=398939"">Bootstrap</a></li>
			</ul>
		</div>
		<div class=""col-md-3"">
			<h2>How to</h2>
			<ul>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkID=398600"">Add a Controller and View</a></li>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkId=699315"">Manage User Secrets using Secret Manager.</a></li>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkId=699316"">Use logging to log a message.</a></li>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkId=699317"">Add packages using NuGet.</a></li>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkId=699319"">Target development, staging or production environment.</a></li>
			</ul>
		</div>
		<div class=""col-md-3"">
			<h2>Overview</h2>
			<ul>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkId=518008"">Conceptual overview");
            WriteLiteral(@" of what is ASP.NET Core</a></li>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkId=699320"">Fundamentals of ASP.NET Core such as Startup and middleware.</a></li>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkId=398602"">Working with Data</a></li>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkId=398603"">Security</a></li>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkID=699321"">Client side development</a></li>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkID=699322"">Develop on different platforms</a></li>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkID=699323"">Read more on the documentation site</a></li>
			</ul>
		</div>
		<div class=""col-md-3"">
			<h2>Run &amp; Deploy</h2>
			<ul>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkID=517851"">Run your app</a></li>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkID=517853"">Run tools such as EF migrations and more</a></li>
				<li><a href=""https://go.microsoft.com/fwlink/?LinkID=398609"">Publis");
            WriteLiteral("h to Microsoft Azure Web Apps</a></li>\r\n\t\t\t</ul>\r\n\t\t</div>\r\n\t</div>\r\n");
            EndContext();
#line 58 "C:\Users\JakeHershberger\Desktop\CODE\shareABite2.0\ShareABite2\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
