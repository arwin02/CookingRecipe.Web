#pragma checksum "C:\Users\VGD PC 9\source\repos\CookingRecipe\CookingRecipe.Web\Areas\Manage\Views\Ingredients\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feabb272ccfcf662a640520285508eb277825e36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Ingredients_Edit), @"mvc.1.0.view", @"/Areas/Manage/Views/Ingredients/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feabb272ccfcf662a640520285508eb277825e36", @"/Areas/Manage/Views/Ingredients/Edit.cshtml")]
    public class Areas_Manage_Views_Ingredients_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CookingRecipe.Web.Areas.Manage.ViewModels.Ingredients.EditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/ingredients/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/ingredients/edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\VGD PC 9\source\repos\CookingRecipe\CookingRecipe.Web\Areas\Manage\Views\Ingredients\Edit.cshtml"
  
    Layout = "~/areas/manage/views/shared/_manageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feabb272ccfcf662a640520285508eb277825e364433", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 261, "\"", 278, 1);
#nullable restore
#line 10 "C:\Users\VGD PC 9\source\repos\CookingRecipe\CookingRecipe.Web\Areas\Manage\Views\Ingredients\Edit.cshtml"
WriteAttributeValue("", 269, Model.Id, 269, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <div class=\"form-group\">\r\n        <label class=\"form-label\">Name</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 421, "\"", 440, 1);
#nullable restore
#line 13 "C:\Users\VGD PC 9\source\repos\CookingRecipe\CookingRecipe.Web\Areas\Manage\Views\Ingredients\Edit.cshtml"
WriteAttributeValue("", 429, Model.Name, 429, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"input a name\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label class=\"form-label\">Quantity</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"Quantity\"");
                BeginWriteAttribute("value", " value=\"", 630, "\"", 653, 1);
#nullable restore
#line 17 "C:\Users\VGD PC 9\source\repos\CookingRecipe\CookingRecipe.Web\Areas\Manage\Views\Ingredients\Edit.cshtml"
WriteAttributeValue("", 638, Model.Quantity, 638, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"input a quantity\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label class=\"form-label\">Unit Cost</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"UnitCost\"");
                BeginWriteAttribute("value", " value=\"", 848, "\"", 871, 1);
#nullable restore
#line 21 "C:\Users\VGD PC 9\source\repos\CookingRecipe\CookingRecipe.Web\Areas\Manage\Views\Ingredients\Edit.cshtml"
WriteAttributeValue("", 856, Model.UnitCost, 856, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"input a unit cost\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <button type=\"submit\" value=\"Edit\" class=\"btn btn-success\">Save</button>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feabb272ccfcf662a640520285508eb277825e367094", async() => {
                    WriteLiteral("Cancel");
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
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CookingRecipe.Web.Areas.Manage.ViewModels.Ingredients.EditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
