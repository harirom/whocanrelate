#pragma checksum "C:\GitWorkSpace\whocanrelate\WhoCanRelate\Views\Home\WritePost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05c14b00afd96ca35d3bfe588229e0207a344d93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WritePost), @"mvc.1.0.view", @"/Views/Home/WritePost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/WritePost.cshtml", typeof(AspNetCore.Views_Home_WritePost))]
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
#line 1 "C:\GitWorkSpace\whocanrelate\WhoCanRelate\Views\_ViewImports.cshtml"
using WhoCanRelate;

#line default
#line hidden
#line 2 "C:\GitWorkSpace\whocanrelate\WhoCanRelate\Views\_ViewImports.cshtml"
using WhoCanRelate.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05c14b00afd96ca35d3bfe588229e0207a344d93", @"/Views/Home/WritePost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73785fbacc74111a4d4248e802941c8964be981b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WritePost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WhoCanRelate.Models.BlogContent>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\GitWorkSpace\whocanrelate\WhoCanRelate\Views\Home\WritePost.cshtml"
  
    ViewData["Title"] = "WritePost";

#line default
#line hidden
            BeginContext(87, 2050, true);
            WriteLiteral(@"
<!--
<h4>Write your content below</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""WritePost"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Id"" class=""control-label""></label>
                <input asp-for=""Id"" class=""form-control"" />
                <span asp-validation-for=""Id"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Title"" class=""control-label""></label>
                <input asp-for=""Title"" class=""form-control"" />
                <span asp-validation-for=""Title"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Image"" class=""control-label""></label>
                <input asp-for=""Image"" class=""form-control"" />
                <span asp-validation-for=""Image"" class=""text-danger""></span>
            </div>
   ");
            WriteLiteral(@"         <div class=""form-group"">
                <label asp-for=""Body"" class=""control-label""></label>
                <input asp-for=""Body"" class=""form-control""/>
                <span asp-validation-for=""Body"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Tag"" class=""control-label""></label>
                <input asp-for=""Tag"" class=""form-control"" />
                <span asp-validation-for=""Tag"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div> 
-->
<section class=""site-section"">
    <div class=""container"">
        <div class=""row mb-4"">
            <div class=""col-md-6"">
                <h1>Blog Post</h1>
            </div>
        </div>
        <div class=""row blog-entries"">
            <div class=""col-md-12 col-lg-8 main-content"">
              ");
            WriteLiteral("  ");
            EndContext();
            BeginContext(2137, 1246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d90cf914bc14f3086b47fd97bd1a788", async() => {
                BeginContext(2168, 1208, true);
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-md-12 form-group"">
                            <label for=""Title"">Title</label>
                            <input type=""text"" id=""Title"" class=""form-control "">
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-md-12 form-group"">
                            <label for=""Tags"">Tags</label>
                            <input type=""text"" id=""Tags"" class=""form-control "">
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-md-12 form-group"">
                            <label for=""Body"">Body</label>
                            <textarea name=""Body"" id=""Body"" class=""form-control "" cols=""30"" rows=""8""></textarea>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-m");
                WriteLiteral("d-6 form-group\">\r\n                            <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\">\r\n                        </div>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3383, 64, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3465, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 89 "C:\GitWorkSpace\whocanrelate\WhoCanRelate\Views\Home\WritePost.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WhoCanRelate.Models.BlogContent> Html { get; private set; }
    }
}
#pragma warning restore 1591
