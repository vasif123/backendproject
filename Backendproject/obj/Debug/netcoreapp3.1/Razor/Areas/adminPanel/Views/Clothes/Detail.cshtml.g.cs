#pragma checksum "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df423dbef5c856e52b483a27e902b09410a15e02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_adminPanel_Views_Clothes_Detail), @"mvc.1.0.view", @"/Areas/adminPanel/Views/Clothes/Detail.cshtml")]
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
#nullable restore
#line 1 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\_ViewImports.cshtml"
using Backendproject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\_ViewImports.cshtml"
using Backendproject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df423dbef5c856e52b483a27e902b09410a15e02", @"/Areas/adminPanel/Views/Clothes/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"529a36ebb4183e2c6b11f7200b2327e4dfb808a8", @"/Areas/adminPanel/Views/_ViewImports.cshtml")]
    public class Areas_adminPanel_Views_Clothes_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Backendproject.Models.Clothes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none text-secondary me-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none text-secondary ms-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"main-panel container\">\n        <h3>Detail</h3>\n    <div class=\"d-flex justify-content-end mt-4\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df423dbef5c856e52b483a27e902b09410a15e025760", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
                                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df423dbef5c856e52b483a27e902b09410a15e028070", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n   \n\n    <div>\n        <h4>Clothes</h4>\n        <hr />\n        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n               Image name\n            </dt>\n            <dd class=\"col-sm-4\">\n                ");
#nullable restore
#line 23 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayFor(model => model.ClothesImages.FirstOrDefault(c => c.IsMain == true).Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dd class=\"col-sm-6\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "df423dbef5c856e52b483a27e902b09410a15e029952", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 817, "~/assets/img/", 817, 13, true);
#nullable restore
#line 26 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
AddHtmlAttributeValue("", 830, Html.DisplayFor(model => model.ClothesImages.FirstOrDefault(c => c.IsMain == true).Name), 830, 89, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
AddHtmlAttributeValue("", 947, Html.DisplayFor(model => model.ClothesImages.FirstOrDefault(c => c.IsMain == true).Alternative), 947, 98, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 30 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 33 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 36 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 39 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 42 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 45 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            \n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 49 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.ClothesInformation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 52 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayFor(model => model.ClothesInformation.AdditionalInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 55 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 58 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 61 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 64 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayFor(model => model.Discount.PercentKey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 67 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.DiscountPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 70 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Areas\adminPanel\Views\Clothes\Detail.cshtml"
           Write(Html.DisplayFor(model => model.DiscountPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n        </dl>\n    </div>\n\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Backendproject.Models.Clothes> Html { get; private set; }
    }
}
#pragma warning restore 1591