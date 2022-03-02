#pragma checksum "/Users/jacob.poor98/Documents/GitHub/Mission08/Mission07/Pages/Purchase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "067fe656e17ff596dea992713ce370d66711f92e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mission07.Pages.Pages_Purchase), @"mvc.1.0.razor-page", @"/Pages/Purchase.cshtml")]
namespace Mission07.Pages
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
#line 4 "/Users/jacob.poor98/Documents/GitHub/Mission08/Mission07/Pages/_ViewImports.cshtml"
using Mission07.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"067fe656e17ff596dea992713ce370d66711f92e", @"/Pages/Purchase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0a4e3df6e2bef449b6fc3ca4d34a6f3bc07e9b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Purchase : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Your Basket</h2>\n\n<table class=\"table table-bordered table-striped\">\n    <thead>\n        <tr>\n            <td>Item</td>\n            <td>Quantity</td>\n            <td>Total</td>\n            <td>Subtotal</td>\n        </tr>\n    </thead>\n\n");
            WriteLiteral("    <tbody>\n");
#nullable restore
#line 20 "/Users/jacob.poor98/Documents/GitHub/Mission08/Mission07/Pages/Purchase.cshtml"
         foreach(var i in Model.basket.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 23 "/Users/jacob.poor98/Documents/GitHub/Mission08/Mission07/Pages/Purchase.cshtml"
               Write(i.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "/Users/jacob.poor98/Documents/GitHub/Mission08/Mission07/Pages/Purchase.cshtml"
               Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>1</td>\n                <td>$");
#nullable restore
#line 26 "/Users/jacob.poor98/Documents/GitHub/Mission08/Mission07/Pages/Purchase.cshtml"
                 Write(i.Quantity * i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 28 "/Users/jacob.poor98/Documents/GitHub/Mission08/Mission07/Pages/Purchase.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n\n");
            WriteLiteral("    <tfoot>\n        <tr>\n            <td colspan=\"3\">Total: </td>\n            <td>");
#nullable restore
#line 35 "/Users/jacob.poor98/Documents/GitHub/Mission08/Mission07/Pages/Purchase.cshtml"
           Write(Model.basket.CalculateTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </tfoot>\n</table>\n\n<div>\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 934, "\"", 957, 1);
#nullable restore
#line 41 "/Users/jacob.poor98/Documents/GitHub/Mission08/Mission07/Pages/Purchase.cshtml"
WriteAttributeValue("", 941, Model.ReturnUrl, 941, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mission07.Pages.PurchaseModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission07.Pages.PurchaseModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission07.Pages.PurchaseModel>)PageContext?.ViewData;
        public Mission07.Pages.PurchaseModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591