#pragma checksum "D:\PROGRAMING\C#\Core\Lamp Shade\Lampshade\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "816ad590e886ed2d419fe85786f9992ef4dbc964"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.LatestArticles.Pages_Shared_Components_LatestArticles_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/LatestArticles/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.LatestArticles
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
#line 1 "D:\PROGRAMING\C#\Core\Lamp Shade\Lampshade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"816ad590e886ed2d419fe85786f9992ef4dbc964", @"/Pages/Shared/Components/LatestArticles/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_LatestArticles_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_LampshadeQuery.Contracts.Article.ArticleQueryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blog-post-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

<div class=""blog-post-slider-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""blog-post-slider-border-wrapper section-space--inner"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""section-title-wrapper text-center section-space--half"">
                                <h2 class=""section-title"">آخرین مقالات سایت</h2>
                                <p class=""section-subtitle"">
                                    لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ
                                </p>
                            </div>
                        </div>
                        <div class=""col-lg-12"">
                            <div class=""blog-post-slider-wrapper"">
                                <div class=""ht-slick-slider"" data-slick-setting='{
                                    ""slidesToShow"": 3,
                   ");
            WriteLiteral(@"                 ""slidesToScroll"": 1,
                                    ""arrows"": false,
                                    ""autoplay"": true,
                                    ""autoplaySpeed"": 1000,
                                    ""speed"": 1000,
                                    ""infinite"": true,
                                    ""rtl"": true
                                }' data-slick-responsive='[
                                    {""breakpoint"":1501, ""settings"": {""slidesToShow"": 3} },
                                    {""breakpoint"":1199, ""settings"": {""slidesToShow"": 3} },
                                    {""breakpoint"":991, ""settings"": {""slidesToShow"": 2} },
                                    {""breakpoint"":767, ""settings"": {""slidesToShow"": 1} },
                                    {""breakpoint"":575, ""settings"": {""slidesToShow"": 1} },
                                    {""breakpoint"":479, ""settings"": {""slidesToShow"": 1} }
                                ]'>
");
#nullable restore
#line 37 "D:\PROGRAMING\C#\Core\Lamp Shade\Lampshade\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
                                     foreach (var article in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""col"">
                                            <div class=""single-slider-post"">
                                                <div class=""single-slider-post__image"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "816ad590e886ed2d419fe85786f9992ef4dbc9647077", async() => {
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "816ad590e886ed2d419fe85786f9992ef4dbc9647388", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2608, "~/Theme/assets/img/products/", 2608, 28, true);
#nullable restore
#line 43 "D:\PROGRAMING\C#\Core\Lamp Shade\Lampshade\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
AddHtmlAttributeValue("", 2636, article.Picture, 2636, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 44 "D:\PROGRAMING\C#\Core\Lamp Shade\Lampshade\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
AddHtmlAttributeValue("", 2739, article.PictureAlt, 2739, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 44 "D:\PROGRAMING\C#\Core\Lamp Shade\Lampshade\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
AddHtmlAttributeValue("", 2767, article.PictureTitle, 2767, 21, false);

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
                WriteLiteral("\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\PROGRAMING\C#\Core\Lamp Shade\Lampshade\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
                                                                             WriteLiteral(article.Slug);

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
            WriteLiteral("\r\n                                                    <div class=\"single-slider-post__date-sticker\">\r\n                                                        <span class=\"month\">");
#nullable restore
#line 47 "D:\PROGRAMING\C#\Core\Lamp Shade\Lampshade\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
                                                                       Write(article.PublishDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                    </div>
                                                </div>
                                                <div class=""single-slider-post__content"">
                                                    <h3 class=""title"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "816ad590e886ed2d419fe85786f9992ef4dbc96412949", async() => {
                WriteLiteral("\r\n                                                            ");
#nullable restore
#line 53 "D:\PROGRAMING\C#\Core\Lamp Shade\Lampshade\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
                                                       Write(article.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "D:\PROGRAMING\C#\Core\Lamp Shade\Lampshade\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
                                                                                 WriteLiteral(article.Slug);

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
            WriteLiteral("\r\n                                                    </h3>\r\n                                                    <p class=\"short-desc\">\r\n                                                        ");
#nullable restore
#line 57 "D:\PROGRAMING\C#\Core\Lamp Shade\Lampshade\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
                                                   Write(article.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </p>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "816ad590e886ed2d419fe85786f9992ef4dbc96416213", async() => {
                WriteLiteral("\r\n                                                        ادامه مطلب\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "D:\PROGRAMING\C#\Core\Lamp Shade\Lampshade\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
                                                                             WriteLiteral(article.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 65 "D:\PROGRAMING\C#\Core\Lamp Shade\Lampshade\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_LampshadeQuery.Contracts.Article.ArticleQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
