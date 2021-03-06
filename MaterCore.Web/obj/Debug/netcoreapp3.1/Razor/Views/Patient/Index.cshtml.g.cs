#pragma checksum "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fcd326e8facc8faf8469130ee89fd9894bcc449"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Index), @"mvc.1.0.view", @"/Views/Patient/Index.cshtml")]
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
#line 1 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\_ViewImports.cshtml"
using MaterCore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\_ViewImports.cshtml"
using MaterCore.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fcd326e8facc8faf8469130ee89fd9894bcc449", @"/Views/Patient/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2559a1f44f813a98a760cf315cf33985d18704", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Patient_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MaterCore.Web.Models.PatientSummaryDTO>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
  
    ViewData["Title"] = "Patient Summary Information";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Patient Detailed Summary</h4>\r\n\r\n\r\n<h6>Name: ");
#nullable restore
#line 11 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<h6>URN: ");
#nullable restore
#line 12 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
    Write(Model.URN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<h6>Date of Birth: ");
#nullable restore
#line 13 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
              Write(Model.DOB.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<h6>Bed: ");
#nullable restore
#line 14 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
    Write(Model.BedNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<h6>Presenting Issue: ");
#nullable restore
#line 15 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
                 Write(Model.Issue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n<hr/>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CommentSummaryDetails[0].Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CommentSummaryDetails[0].Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CommentSummaryDetails[0].Nurse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CommentSummaryDetails[0].Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
         foreach (var item in Model.CommentSummaryDetails)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nurse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 55 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    <a");
            BeginWriteAttribute("href", " href=", 1589, "", 1623, 1);
#nullable restore
#line 60 "C:\Dinesh\MaterProjectUpdate\MaterCore.Web\Views\Patient\Index.cshtml"
WriteAttributeValue("", 1595, Url.Action("Index", "Home"), 1595, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Back to List</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MaterCore.Web.Models.PatientSummaryDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
