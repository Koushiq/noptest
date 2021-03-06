#pragma checksum "C:\Users\BS564\source\repos\NopCommerceClone\NopCommerceClone\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8909e25cea6ebd3cb4fff34b1f2ca60faf95df37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\BS564\source\repos\NopCommerceClone\NopCommerceClone\Views\_ViewImports.cshtml"
using NopCommerceClone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BS564\source\repos\NopCommerceClone\NopCommerceClone\Views\_ViewImports.cshtml"
using NopCommerceClone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8909e25cea6ebd3cb4fff34b1f2ca60faf95df37", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9322af7f9edb3824cf585d76def72bff1e089561", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NopCommerceClone.Models.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\BS564\source\repos\NopCommerceClone\NopCommerceClone\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>
    $(document).ready(function () {
        console.log('Hello world !');

        $('#myTable').DataTable();
    });
</script>

<div class=""text-center"">
    <h1 class=""display-4"">Welcome to the NopCommerce Clone Store!</h1>
    <p>Search for your desired products</p>

    <table id=""myTable"">
        <thead>
            <tr>
                <th>
                    Product ID
                </th>

                <th>
                    Product Name
                </th>
                <th>
                    Product Price
                </th>
                <th>
                    Category
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 39 "C:\Users\BS564\source\repos\NopCommerceClone\NopCommerceClone\Views\Home\Index.cshtml"
              
                foreach (var item in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\BS564\source\repos\NopCommerceClone\NopCommerceClone\Views\Home\Index.cshtml"
                       Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 44 "C:\Users\BS564\source\repos\NopCommerceClone\NopCommerceClone\Views\Home\Index.cshtml"
                        Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\BS564\source\repos\NopCommerceClone\NopCommerceClone\Views\Home\Index.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\BS564\source\repos\NopCommerceClone\NopCommerceClone\Views\Home\Index.cshtml"
                       Write(item.Catelog.CatelogName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 48 "C:\Users\BS564\source\repos\NopCommerceClone\NopCommerceClone\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NopCommerceClone.Models.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
