#pragma checksum "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e15b42952c0a5cb21f88a9a466f7e4d9c9600a79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PetProject.Pages.Pages_Product), @"mvc.1.0.razor-page", @"/Pages/Product.cshtml")]
namespace PetProject.Pages
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
#line 1 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\_ViewImports.cshtml"
using PetProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\_ViewImports.cshtml"
using PetProject.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15b42952c0a5cb21f88a9a466f7e4d9c9600a79", @"/Pages/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5076cba04b8246b217b1d6ac7a57e4ac164b2104", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Product : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Buy Me"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(@"background-color: #f44336;
                                                    border:none;
                                                    text-align:center;
                                                    color:snow;
                                                    display:block;
                                                    margin: 10px 0;
                                                    padding: 10px;
                                                    width: 100%;
                                                    "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Buyme", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Product.cshtml"
  
    ViewData["Title"] = Model.Fighter.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card\" style=\" border-color: #f44336\">\r\n        <div class=\"card-body\">\r\n            <h2 class=\"card-text\">");
#nullable restore
#line 9 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Product.cshtml"
                             Write(Model.Fighter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 314, "\"", 340, 1);
#nullable restore
#line 11 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Product.cshtml"
WriteAttributeValue("", 320, Model.Fighter.Image, 320, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 341, "\"", 366, 1);
#nullable restore
#line 11 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Product.cshtml"
WriteAttributeValue("", 347, Model.Fighter.Name, 347, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:100%\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Product.cshtml"
         if (Model.SignInManager.IsSignedIn(User))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e15b42952c0a5cb21f88a9a466f7e4d9c9600a797399", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e15b42952c0a5cb21f88a9a466f7e4d9c9600a797673", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Product.cshtml"
                                                                                 WriteLiteral(Model.Fighter.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Product.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PetProject.Pages.ProductModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PetProject.Pages.ProductModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PetProject.Pages.ProductModel>)PageContext?.ViewData;
        public PetProject.Pages.ProductModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
