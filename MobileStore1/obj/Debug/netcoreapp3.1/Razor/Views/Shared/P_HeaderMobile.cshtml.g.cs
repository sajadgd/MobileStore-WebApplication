#pragma checksum "E:\Web\MobileStore1\Views\Shared\P_HeaderMobile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aec2e61f479c2f7c7d74afa257459de9f6be0262"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_P_HeaderMobile), @"mvc.1.0.view", @"/Views/Shared/P_HeaderMobile.cshtml")]
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
#line 1 "E:\Web\MobileStore1\Views\_ViewImports.cshtml"
using MobileStore1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec2e61f479c2f7c7d74afa257459de9f6be0262", @"/Views/Shared/P_HeaderMobile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fe3fd3b9ba5b3e8c2c8a2fc4cde00910443ac3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_P_HeaderMobile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SiteContent/images/cart1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SiteContent/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<header class=\"responsive-header\">\r\n    <div class=\"top-bar\">\r\n        <ul class=\"shop-cart bar-dropdown\">\r\n            <li>\r\n                <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 153, "\"", 161, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                <ul>\r\n                    <li>\r\n                        <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aec2e61f479c2f7c7d74afa257459de9f6be02625774", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n                        <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 377, "\"", 385, 0);
            EndWriteAttribute();
            WriteLiteral(">???? ?????? - 2013</a>\r\n                        <i>36000 ??????????</i>\r\n                        <div class=\"cart-bar-hover\">\r\n                            <ul>\r\n                                <li><a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 585, "\"", 593, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-cog\"></i></a></li>\r\n                                <li><a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 678, "\"", 686, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash-o\"></i></a></li>\r\n                            </ul>\r\n                        </div>\r\n                    </li>\r\n                    <li>\r\n                        <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aec2e61f479c2f7c7d74afa257459de9f6be02627855", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n                        <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 973, "\"", 981, 0);
            EndWriteAttribute();
            WriteLiteral(">?????? - ???? ??????</a>\r\n                        <i>56000 ??????????</i>\r\n                        <div class=\"cart-bar-hover\">\r\n                            <ul>\r\n                                <li><a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 1180, "\"", 1188, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-cog\"></i></a></li>\r\n                                <li><a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 1273, "\"", 1281, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash-o\"></i></a></li>\r\n                            </ul>\r\n                        </div>\r\n                    </li>\r\n\r\n                    <li>\r\n                        <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aec2e61f479c2f7c7d74afa257459de9f6be02629943", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n                        <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 1570, "\"", 1578, 0);
            EndWriteAttribute();
            WriteLiteral(">?????????? ???????? </a>\r\n                        <i>56000 ??????????</i>\r\n                        <div class=\"cart-bar-hover\">\r\n                            <ul>\r\n                                <li><a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 1776, "\"", 1784, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-cog\"></i></a></li>\r\n                                <li><a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 1869, "\"", 1877, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash-o\"></i></a></li>\r\n                            </ul>\r\n                        </div>\r\n\r\n                    </li>\r\n                    <li>\r\n                        <h6>??????: 99000 ?????????? </h6>\r\n                        <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 2128, "\"", 2136, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"checkout-btn\">????????????</a>\r\n                    </li>\r\n                </ul>\r\n            </li>\r\n        </ul>\r\n\r\n\r\n        <ul class=\"compare-btn bar-dropdown\">\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aec2e61f479c2f7c7d74afa257459de9f6be026212440", async() => {
                WriteLiteral("<i class=\"fa fa-inbox\"></i>?????? ??????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n        </ul>\r\n\r\n\r\n        <ul class=\"whishlist-bar bar-dropdown\">\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aec2e61f479c2f7c7d74afa257459de9f6be026213923", async() => {
                WriteLiteral("<i class=\"fa fa-inbox\"></i>???????? ???? ????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n\r\n    <div class=\"logo\">\r\n        <a href=\"./index.html\"");
            BeginWriteAttribute("title", " title=\"", 2685, "\"", 2693, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aec2e61f479c2f7c7d74afa257459de9f6be026215571", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </a>\r\n    </div>\r\n\r\n    <div class=\"search-header\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aec2e61f479c2f7c7d74afa257459de9f6be026216764", async() => {
                WriteLiteral("<input type=\"text\" placeholder=\"??????????\" /><a href=\"#\"");
                BeginWriteAttribute("title", " title=\"", 2888, "\"", 2896, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-search\"></i></a>");
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
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"responsive-menu\">\r\n        <a class=\"menu-dropdown-btn\"");
            BeginWriteAttribute("title", " title=\"", 3024, "\"", 3032, 0);
            EndWriteAttribute();
            WriteLiteral(">?????? <i class=\"fa fa-align-justify\"></i></a>\r\n        <ul>\r\n            <li>\r\n                <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 3138, "\"", 3146, 0);
            EndWriteAttribute();
            WriteLiteral(">????????</a>\r\n                <ul>\r\n                    <li><a href=\"./index.html\"");
            BeginWriteAttribute("title", " title=\"", 3226, "\"", 3234, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? 1</a></li>\r\n                    <li><a href=\"./index2.html\"");
            BeginWriteAttribute("title", " title=\"", 3300, "\"", 3308, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? 2</a></li>\r\n                    <li><a href=\"./index3.html\"");
            BeginWriteAttribute("title", " title=\"", 3374, "\"", 3382, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? 3</a></li>\r\n                    <li><a href=\"./index4.html\"");
            BeginWriteAttribute("title", " title=\"", 3448, "\"", 3456, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? - ???????????????? 1</a></li>\r\n                    <li><a href=\"./index5.html\"");
            BeginWriteAttribute("title", " title=\"", 3533, "\"", 3541, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? - ???????????????? 2</a></li>\r\n                    <li><a href=\"./index11.html\"");
            BeginWriteAttribute("title", " title=\"", 3619, "\"", 3627, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? - ???????????????? 3</a></li>\r\n                    <li><a href=\"./index6.html\"");
            BeginWriteAttribute("title", " title=\"", 3704, "\"", 3712, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? 6</a></li>\r\n                    <li><a href=\"./index7.html\"");
            BeginWriteAttribute("title", " title=\"", 3778, "\"", 3786, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? - ??????????</a></li>\r\n                    <li><a href=\"./index8.html\"");
            BeginWriteAttribute("title", " title=\"", 3858, "\"", 3866, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? - ??????????????</a></li>\r\n                    <li><a href=\"./index9.html\"");
            BeginWriteAttribute("title", " title=\"", 3940, "\"", 3948, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? - ????????</a></li>\r\n                    <li><a href=\"./index12.html\"");
            BeginWriteAttribute("title", " title=\"", 4020, "\"", 4028, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? - ???????? 2</a></li>\r\n                    <li><a href=\"./index10.html\"");
            BeginWriteAttribute("title", " title=\"", 4102, "\"", 4110, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? 12</a></li>\r\n                </ul>\r\n            </li>\r\n\r\n            <li>\r\n                <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 4219, "\"", 4227, 0);
            EndWriteAttribute();
            WriteLiteral(">?????????? ????????</a>\r\n                <ul>\r\n                    <li><a href=\"./mega-menu.html\"");
            BeginWriteAttribute("title", " title=\"", 4317, "\"", 4325, 0);
            EndWriteAttribute();
            WriteLiteral(">4 ?????? ??????</a></li>\r\n                    <li>\r\n                        <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 4408, "\"", 4416, 0);
            EndWriteAttribute();
            WriteLiteral(">?????? ?????? ??????</a>\r\n                        <ul>\r\n                            <li><a href=\"./header1.html\"");
            BeginWriteAttribute("title", " title=\"", 4521, "\"", 4529, 0);
            EndWriteAttribute();
            WriteLiteral(">?????? ?????????? 1</a></li>\r\n                            <li><a href=\"./header2.html\"");
            BeginWriteAttribute("title", " title=\"", 4609, "\"", 4617, 0);
            EndWriteAttribute();
            WriteLiteral(">?????? ?????????? 2</a></li>\r\n\r\n                        </ul>\r\n                    </li>\r\n                    <li><a href=\"./boxed.html\"");
            BeginWriteAttribute("title", " title=\"", 4747, "\"", 4755, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? ????????????</a></li>\r\n                    <li><a href=\"./wide.html\"");
            BeginWriteAttribute("title", " title=\"", 4824, "\"", 4832, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? ??????</a></li>\r\n                    <li>\r\n                        <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 4914, "\"", 4922, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? ????????????</a>\r\n                        <ul>\r\n                            <li><a href=\"./compare.html\"");
            BeginWriteAttribute("title", " title=\"", 5027, "\"", 5035, 0);
            EndWriteAttribute();
            WriteLiteral(">???????????? ?????????? 1 </a></li>\r\n                            <li><a href=\"./compare2.html\"");
            BeginWriteAttribute("title", " title=\"", 5120, "\"", 5128, 0);
            EndWriteAttribute();
            WriteLiteral(">???????????? ?????????? 2</a></li>\r\n                        </ul>\r\n                    </li>\r\n                    <li><a href=\"./widgets.html\"");
            BeginWriteAttribute("title", " title=\"", 5261, "\"", 5269, 0);
            EndWriteAttribute();
            WriteLiteral(">??????????????</a></li>\r\n                    <li>\r\n                        <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 5350, "\"", 5358, 0);
            EndWriteAttribute();
            WriteLiteral(">??????????????</a>\r\n                        <ul>\r\n                            <li><a href=\"./product1.html\"");
            BeginWriteAttribute("title", " title=\"", 5460, "\"", 5468, 0);
            EndWriteAttribute();
            WriteLiteral(">?????????????? 1</a></li>\r\n                            <li><a href=\"./product4.html\"");
            BeginWriteAttribute("title", " title=\"", 5547, "\"", 5555, 0);
            EndWriteAttribute();
            WriteLiteral(">?????????????? 2</a></li>\r\n                            <li><a href=\"./product3.html\"");
            BeginWriteAttribute("title", " title=\"", 5634, "\"", 5642, 0);
            EndWriteAttribute();
            WriteLiteral(">?????????? ??????????????</a></li>\r\n                            <li><a href=\"./product2.html\"");
            BeginWriteAttribute("title", " title=\"", 5725, "\"", 5733, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? ??????????</a></li>\r\n                        </ul>\r\n                    </li>\r\n                    <li><a href=\"./price-table.html\"");
            BeginWriteAttribute("title", " title=\"", 5866, "\"", 5874, 0);
            EndWriteAttribute();
            WriteLiteral(">2 ???????? ????????</a></li>\r\n                </ul>\r\n            </li>\r\n            <li>\r\n                <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 5985, "\"", 5993, 0);
            EndWriteAttribute();
            WriteLiteral(">??????????</a>\r\n                <ul class=\"mega2\">\r\n                    <li>\r\n                        <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 6103, "\"", 6111, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? ????????????</a>\r\n                        <ul>\r\n                            <li><a href=\"./cart.html\"");
            BeginWriteAttribute("title", " title=\"", 6213, "\"", 6221, 0);
            EndWriteAttribute();
            WriteLiteral(">????????????</a></li>\r\n                        </ul>\r\n                    </li>\r\n                    <li>\r\n                        <a href=\"./index.html\"");
            BeginWriteAttribute("title", " title=\"", 6370, "\"", 6378, 0);
            EndWriteAttribute();
            WriteLiteral(">??????????</a>\r\n                        <ul>\r\n                            <li><a href=\"./blog.html\"");
            BeginWriteAttribute("title", " title=\"", 6474, "\"", 6482, 0);
            EndWriteAttribute();
            WriteLiteral(">??????????</a></li>\r\n                            <li><a href=\"./blog2.html\"");
            BeginWriteAttribute("title", " title=\"", 6554, "\"", 6562, 0);
            EndWriteAttribute();
            WriteLiteral(">?????????? ???? ??????????</a></li>\r\n                        </ul>\r\n                    </li>\r\n\r\n                    <li>\r\n                        <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 6710, "\"", 6718, 0);
            EndWriteAttribute();
            WriteLiteral(">??????????????</a>\r\n                        <ul>\r\n                            <li><a href=\"./product1.html\"");
            BeginWriteAttribute("title", " title=\"", 6820, "\"", 6828, 0);
            EndWriteAttribute();
            WriteLiteral(">?????????????? 1</a></li>\r\n                            <li><a href=\"./product4.html\"");
            BeginWriteAttribute("title", " title=\"", 6907, "\"", 6915, 0);
            EndWriteAttribute();
            WriteLiteral(">?????????????? 2</a></li>\r\n                            <li><a href=\"./product3.html\"");
            BeginWriteAttribute("title", " title=\"", 6994, "\"", 7002, 0);
            EndWriteAttribute();
            WriteLiteral(">?????????? ??????????????</a></li>\r\n                            <li><a href=\"./product2.html\"");
            BeginWriteAttribute("title", " title=\"", 7085, "\"", 7093, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? ??????????</a></li>\r\n                        </ul>\r\n                    </li>\r\n\r\n                    <li>\r\n                        <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 7237, "\"", 7245, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? ????????????</a>\r\n                        <ul>\r\n                            <li><a href=\"./compare.html\"");
            BeginWriteAttribute("title", " title=\"", 7350, "\"", 7358, 0);
            EndWriteAttribute();
            WriteLiteral(">???????????? ?????????? 1 </a></li>\r\n                            <li><a href=\"./compare2.html\"");
            BeginWriteAttribute("title", " title=\"", 7443, "\"", 7451, 0);
            EndWriteAttribute();
            WriteLiteral(">???????????? ?????????? 2</a></li>\r\n                        </ul>\r\n                    </li>\r\n                    <li><a href=\"./review.html\"");
            BeginWriteAttribute("title", " title=\"", 7583, "\"", 7591, 0);
            EndWriteAttribute();
            WriteLiteral(">?????? ??????????</a></li>\r\n                    <li><a href=\"./404.html\"");
            BeginWriteAttribute("title", " title=\"", 7657, "\"", 7665, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? 404</a></li>\r\n                    <li><a href=\"./faq.html\"");
            BeginWriteAttribute("title", " title=\"", 7730, "\"", 7738, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? ?? ????????</a></li>\r\n                    <li><a href=\"./single-post.html\"");
            BeginWriteAttribute("title", " title=\"", 7814, "\"", 7822, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? ?????????? ??????????????</a></li>\r\n                </ul>\r\n            </li>\r\n            <li>\r\n                <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 7940, "\"", 7948, 0);
            EndWriteAttribute();
            WriteLiteral(">?????????? ??????????</a>\r\n                <ul>\r\n                    <li><a href=\"./price-table.html\"");
            BeginWriteAttribute("title", " title=\"", 8041, "\"", 8049, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? ????????</a></li>\r\n                    <li><a href=\"./office.html\"");
            BeginWriteAttribute("title", " title=\"", 8118, "\"", 8126, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? ????</a></li>\r\n                    <li><a href=\"./skills.html\"");
            BeginWriteAttribute("title", " title=\"", 8193, "\"", 8201, 0);
            EndWriteAttribute();
            WriteLiteral(">?????????? ????</a></li>\r\n                    <li><a href=\"./services.html\"");
            BeginWriteAttribute("title", " title=\"", 8271, "\"", 8279, 0);
            EndWriteAttribute();
            WriteLiteral(">?????????? ????</a></li>\r\n                    <li><a href=\"./team.html\"");
            BeginWriteAttribute("title", " title=\"", 8345, "\"", 8353, 0);
            EndWriteAttribute();
            WriteLiteral(">?????? ????</a></li>\r\n                    <li><a href=\"./faq.html\"");
            BeginWriteAttribute("title", " title=\"", 8416, "\"", 8424, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? ?? ????????</a></li>\r\n                </ul>\r\n            </li>\r\n\r\n            <li><a href=\"./about.html\"");
            BeginWriteAttribute("title", " title=\"", 8530, "\"", 8538, 0);
            EndWriteAttribute();
            WriteLiteral(">???????????? ???? </a></li>\r\n            <li><a href=\"./contact.html\"");
            BeginWriteAttribute("title", " title=\"", 8601, "\"", 8609, 0);
            EndWriteAttribute();
            WriteLiteral(">???????? ???? ????</a></li>\r\n        </ul>\r\n    </div>\r\n</header>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
