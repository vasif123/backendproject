#pragma checksum "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3eee94b334bbdea54d085e7ed32330fdac9a85b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\_ViewImports.cshtml"
using Backendproject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\_ViewImports.cshtml"
using Backendproject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3eee94b334bbdea54d085e7ed32330fdac9a85b", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"529a36ebb4183e2c6b11f7200b2327e4dfb808a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/user.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mr-3 mt-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 45px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Breadcrumb Start -->\n<div class=\"container-fluid\">\n    <div class=\"row px-xl-5\">\n        <div class=\"col-12\">\n            <nav class=\"breadcrumb bg-light mb-30\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3eee94b334bbdea54d085e7ed32330fdac9a85b7223", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3eee94b334bbdea54d085e7ed32330fdac9a85b8679", async() => {
                WriteLiteral("Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <span class=""breadcrumb-item active"">Shop Detail</span>
            </nav>
        </div>
    </div>
</div>
<!-- Breadcrumb End -->


<!-- Shop Detail Start -->
<div class=""container-fluid pb-5"">
    <div class=""row px-xl-5"">
        <div class=""col-lg-5 mb-30"">
            <div id=""product-carousel"" class=""carousel slide"" data-ride=""carousel"">
                <div class=""carousel-inner bg-light"">
");
#nullable restore
#line 28 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
                     foreach (ClothesImage clothesImage in Model.Clothes.ClothesImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1004, "\"", 1054, 2);
            WriteAttributeValue("", 1012, "carousel-item", 1012, 13, true);
#nullable restore
#line 30 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
WriteAttributeValue(" ", 1025, count == 0 ? "active":"" , 1026, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b3eee94b334bbdea54d085e7ed32330fdac9a85b11394", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1115, "~/assets/img/", 1115, 13, true);
#nullable restore
#line 31 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 1128, clothesImage.Name, 1128, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 1153, clothesImage.Alternative, 1153, 25, false);

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
            WriteLiteral("\n                        </div>\n");
#nullable restore
#line 33 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
                    Write(count=1);

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
                                  ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <a class=""carousel-control-prev"" href=""#product-carousel"" data-slide=""prev"">
                    <i class=""fa fa-2x fa-angle-left text-dark""></i>
                </a>
                <a class=""carousel-control-next"" href=""#product-carousel"" data-slide=""next"">
                    <i class=""fa fa-2x fa-angle-right text-dark""></i>
                </a>
            </div>
        </div>

        <div class=""col-lg-7 h-auto mb-30"">
            <div class=""h-100 bg-light p-30"">
                <h3>");
#nullable restore
#line 48 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
               Write(Model.Clothes.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <div class=""d-flex mb-3"">
                    <div class=""text-primary mr-2"">
                        <small class=""fas fa-star""></small>
                        <small class=""fas fa-star""></small>
                        <small class=""fas fa-star""></small>
                        <small class=""fas fa-star-half-alt""></small>
                        <small class=""far fa-star""></small>
                    </div>
                    <small class=""pt-1"">(99 Reviews)</small>
                </div>
                <h3 class=""font-weight-semi-bold mb-4"">$");
#nullable restore
#line 59 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
                                                   Write(Model.Clothes.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                <p class=\"mb-4\">\n");
#nullable restore
#line 61 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
                      

                        if (Model.Clothes.Description.Length > 50)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
                       Write(Model.Clothes.Description.Substring(0, 50));

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
                                                                       ;

                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
                       Write(Model.Clothes.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
                                                      ;
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </p>\n\n                <div class=\"d-flex mb-4\">\n                    <strong class=\"text-dark mr-3\">Colors:</strong>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3eee94b334bbdea54d085e7ed32330fdac9a85b17331", async() => {
                WriteLiteral(@"
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio""  class=""custom-control-input"" id=""color-1"" name=""color"">
                            <label class=""custom-control-label"" for=""color-1"">Black</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-2"" name=""color"">
                            <label class=""custom-control-label"" for=""color-2"">White</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-3"" name=""color"">
                            <label class=""custom-control-label"" for=""color-3"">Red</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-");
                WriteLiteral(@"inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-4"" name=""color"">
                            <label class=""custom-control-label"" for=""color-4"">Blue</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-5"" name=""color"">
                            <label class=""custom-control-label"" for=""color-5"">Green</label>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <div class=\"d-flex mb-3\">\n                    <strong class=\"text-dark mr-3\">Sizes:</strong>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3eee94b334bbdea54d085e7ed32330fdac9a85b20417", async() => {
                WriteLiteral("\n\n\n");
                WriteLiteral("\n");
                WriteLiteral("\n");
                WriteLiteral("                            \n\n\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""d-flex align-items-center mb-4 pt-2"">
                    <div class=""input-group quantity mr-3"" style=""width: 130px;"">
                        <div class=""input-group-btn"">
                            <button class=""btn btn-primary btn-minus"">
                                <i class=""fa fa-minus""></i>
                            </button>
                        </div>
                        <input type=""text"" class=""form-control bg-secondary border-0 text-center"" value=""1"">
                        <div class=""input-group-btn"">
                            <button class=""btn btn-primary btn-plus"">
                                <i class=""fa fa-plus""></i>
                            </button>
                        </div>
                    </div>
                    <button class=""btn btn-primary px-3"">
                        <i class=""fa fa-shopping-cart mr-1""></i> Add To
                        Cart
                    </button>
                </div");
            WriteLiteral(">\n                <div class=\"d-flex pt-2\">\n                    <strong class=\"text-dark mr-2\">Share on:</strong>\n                    <div class=\"d-inline-flex\">\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 6954, "\"", 6961, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            <i class=\"fab fa-facebook-f\"></i>\n                        </a>\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7104, "\"", 7111, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            <i class=\"fab fa-twitter\"></i>\n                        </a>\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7251, "\"", 7258, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            <i class=\"fab fa-linkedin-in\"></i>\n                        </a>\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7402, "\"", 7409, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fab fa-pinterest""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row px-xl-5"">
        <div class=""col"">
            <div class=""bg-light p-30"">
                <div class=""nav nav-tabs mb-4"">
                    <a class=""nav-item nav-link text-dark active"" data-toggle=""tab"" href=""#tab-pane-1"">Description</a>
                    <a class=""nav-item nav-link text-dark"" data-toggle=""tab"" href=""#tab-pane-2"">Information</a>
                    <a class=""nav-item nav-link text-dark"" data-toggle=""tab"" href=""#tab-pane-3"">Reviews (0)</a>
                </div>
                <div class=""tab-content"">
                    <div class=""tab-pane fade show active"" id=""tab-pane-1"">
                        <h4 class=""mb-3"">Product Description</h4>
                       <p>");
#nullable restore
#line 178 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
                     Write(Model.Clothes.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                    <div class=\"tab-pane fade\" id=\"tab-pane-2\">\n                        <h4 class=\"mb-3\">Additional Information</h4>\n                        <p>");
#nullable restore
#line 182 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
                      Write(Model.Clothes.ExtraInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <ul class=""list-group list-group-flush"">
                                    <li class=""list-group-item px-0"">
                                        Sit erat duo lorem duo ea consetetur, et eirmod takimata.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Amet kasd gubergren sit sanctus et lorem eos sadipscing at.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Duo amet accusam eirmod nonumy stet et et stet eirmod.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Takimata ea clita labore amet ipsum erat justo voluptua. Nonumy.
                                    </li>
       ");
            WriteLiteral(@"                         </ul>
                            </div>
                            <div class=""col-md-6"">
                                <ul class=""list-group list-group-flush"">
                                    <li class=""list-group-item px-0"">
                                        Sit erat duo lorem duo ea consetetur, et eirmod takimata.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Amet kasd gubergren sit sanctus et lorem eos sadipscing at.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Duo amet accusam eirmod nonumy stet et et stet eirmod.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Takimata ea clita labore amet ipsum erat justo voluptua. Nonumy.
                              ");
            WriteLiteral(@"      </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""tab-pane-3"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <h4 class=""mb-4"">1 review for ""Product Name""</h4>
                                <div class=""media mb-4"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b3eee94b334bbdea54d085e7ed32330fdac9a85b28417", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <div class=""media-body"">
                                        <h6>John Doe<small> - <i>01 Jan 2045</i></small></h6>
                                        <div class=""text-primary mb-2"">
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star-half-alt""></i>
                                            <i class=""far fa-star""></i>
                                        </div>
                                        <p>Diam amet duo labore stet elitr ea clita ipsum, tempor labore accusam ipsum et no at. Kasd diam tempor rebum magna dolores sed sed eirmod ipsum.</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                    ");
            WriteLiteral(@"            <h4 class=""mb-4"">Leave a review</h4>
                                <small>Your email address will not be published. Required fields are marked *</small>
                                <div class=""d-flex my-3"">
                                    <p class=""mb-0 mr-2"">Your Rating * :</p>
                                    <div class=""text-primary"">
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                    </div>
                                </div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3eee94b334bbdea54d085e7ed32330fdac9a85b31604", async() => {
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <label for=""message"">Your Review *</label>
                                        <textarea id=""message"" cols=""30"" rows=""5"" class=""form-control""></textarea>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""name"">Your Name *</label>
                                        <input type=""text"" class=""form-control"" id=""name"">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""email"">Your Email *</label>
                                        <input type=""email"" class=""form-control"" id=""email"">
                                    </div>
                                    <div class=""form-group mb-0"">
                                        <input type=""submit"" value=""Leave Your Review"" class=""btn btn-pri");
                WriteLiteral("mary px-3\">\n                                    </div>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Shop Detail End -->
<!-- Products Start -->
<div class=""container-fluid py-5"">
    <h2 class=""section-title position-relative text-uppercase mx-xl-5 mb-4""><span class=""bg-secondary pr-3"">You May Also Like</span></h2>
    <div class=""row px-xl-5"">
        
                
            ");
#nullable restore
#line 282 "C:\Users\UX463FL\OneDrive\Desktop\Backendproject\Backendproject\Views\Product\Detail.cshtml"
       Write(await Html.PartialAsync("_ClothesPartialView",Model.Clotheses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        \n    </div>\n</div>\n<!-- Products End -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
