#pragma checksum "d:\belgeler\Desktop\javascript proje\BlogApp\BlogApp.WebUI\Views\Shared\_BlogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47dd752eefa6f1de3046437f74292e26b6afa1c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BlogList), @"mvc.1.0.view", @"/Views/Shared/_BlogList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_BlogList.cshtml", typeof(AspNetCore.Views_Shared__BlogList))]
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
#line 1 "d:\belgeler\Desktop\javascript proje\BlogApp\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47dd752eefa6f1de3046437f74292e26b6afa1c3", @"/Views/Shared/_BlogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"472accd22f53e837c685546400ebe6510d75433f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BlogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "d:\belgeler\Desktop\javascript proje\BlogApp\BlogApp.WebUI\Views\Shared\_BlogList.cshtml"
  
    Layout=null;

#line default
#line hidden
            BeginContext(51, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 5 "d:\belgeler\Desktop\javascript proje\BlogApp\BlogApp.WebUI\Views\Shared\_BlogList.cshtml"
  foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(93, 123, true);
            WriteLiteral("                       <div class=\"card mt-2\">\r\n                        <div class=\"card-header\">\r\n                        ");
            EndContext();
            BeginContext(217, 10, false);
#line 9 "d:\belgeler\Desktop\javascript proje\BlogApp\BlogApp.WebUI\Views\Shared\_BlogList.cshtml"
                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(227, 60, true);
            WriteLiteral("\r\n                        </div>\r\n                          ");
            EndContext();
            BeginContext(287, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47dd752eefa6f1de3046437f74292e26b6afa1c34758", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 297, "~/img/", 297, 6, true);
#line 11 "d:\belgeler\Desktop\javascript proje\BlogApp\BlogApp.WebUI\Views\Shared\_BlogList.cshtml"
AddHtmlAttributeValue("", 303, item.Image, 303, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(343, 119, true);
            WriteLiteral("\r\n                       \r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(463, 10, false);
#line 14 "d:\belgeler\Desktop\javascript proje\BlogApp\BlogApp.WebUI\Views\Shared\_BlogList.cshtml"
                                          Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(473, 52, true);
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(526, 16, false);
#line 15 "d:\belgeler\Desktop\javascript proje\BlogApp\BlogApp.WebUI\Views\Shared\_BlogList.cshtml"
                                        Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(542, 142, true);
            WriteLiteral("</p>\r\n                         <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\r\n                    </div>\r\n                    </div> \r\n");
            EndContext();
#line 19 "d:\belgeler\Desktop\javascript proje\BlogApp\BlogApp.WebUI\Views\Shared\_BlogList.cshtml"
        }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591