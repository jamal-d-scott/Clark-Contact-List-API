#pragma checksum "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b517e2b6a42a1e287ba74871d23810522ff07a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Index), @"mvc.1.0.view", @"/Views/Contacts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contacts/Index.cshtml", typeof(AspNetCore.Views_Contacts_Index))]
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
#line 1 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\_ViewImports.cshtml"
using ClarkCodingChallenge;

#line default
#line hidden
#line 2 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\_ViewImports.cshtml"
using ClarkCodingChallenge.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b517e2b6a42a1e287ba74871d23810522ff07a6", @"/Views/Contacts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d067e1e9653956985e0b9a135efe012d2c0260c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClarkCodingChallenge.Models.ContactsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
  
    ViewData["Title"] = "Contacts Page";

#line default
#line hidden
            BeginContext(105, 154, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">New Contact</h1>\r\n</div>\r\n<br />\r\n<div class=\"new-contact-form\">\r\n    <div class=\"form-controls\">\r\n");
            EndContext();
#line 13 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
         using (Html.BeginForm("AddNewContact", "Contacts"))
        {
            

#line default
#line hidden
            BeginContext(345, 23, false);
#line 15 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(383, 28, false);
#line 16 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(415, 35, true);
            WriteLiteral("            <div>\r\n                ");
            EndContext();
            BeginContext(451, 31, false);
#line 19 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
           Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(482, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(501, 146, false);
#line 20 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
           Write(Html.EditorFor(m => m.FirstName, new { htmlAttributes = new { @class = "form-textbox-wide", @id = "txtFirstName", @placeholder = "First Name" } }));

#line default
#line hidden
            EndContext();
            BeginContext(647, 43, true);
            WriteLiteral("\r\n                <span class=\"form-error\">");
            EndContext();
            BeginContext(691, 43, false);
#line 21 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
                                    Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(734, 84, true);
            WriteLiteral("</span>\r\n            </div>\r\n            <br />\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(819, 30, false);
#line 25 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
           Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(849, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(868, 143, false);
#line 26 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
           Write(Html.EditorFor(m => m.LastName, new { htmlAttributes = new { @class = "form-textbox-wide", @id = "txtLastName", @placeholder = "Last Name" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 43, true);
            WriteLiteral("\r\n                <span class=\"form-error\">");
            EndContext();
            BeginContext(1055, 42, false);
#line 27 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
                                    Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 84, true);
            WriteLiteral("</span>\r\n            </div>\r\n            <br />\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(1182, 34, false);
#line 31 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
           Write(Html.LabelFor(m => m.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1235, 155, false);
#line 32 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
           Write(Html.EditorFor(m => m.EmailAddress, new { htmlAttributes = new { @class = "form-textbox-wide", @id = "txtEmailAddress", @placeholder = "Email Address" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1390, 43, true);
            WriteLiteral("\r\n                <span class=\"form-error\">");
            EndContext();
            BeginContext(1434, 46, false);
#line 33 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
                                    Write(Html.ValidationMessageFor(m => m.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 303, true);
            WriteLiteral(@"</span>
            </div>
            <br />
            <div class=""form-button-group"">
                <button type=""submit"" class=""form-button submit-Button"">Submit</button>
                <button type=""button"" class=""form-button"" onclick=""ClearFormData()"">Clear</button>
            </div>
");
            EndContext();
#line 40 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1794, 62, true);
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"new-contact-form-links\">\r\n    ");
            EndContext();
            BeginContext(1857, 71, false);
#line 44 "H:\GitHub Repositories\Clark-Contact-List-API\ClarkCodingChallenge\Views\Contacts\Index.cshtml"
Write(Html.ActionLink("View Contact List Page", "GetMailingList", "Contacts"));

#line default
#line hidden
            EndContext();
            BeginContext(1928, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClarkCodingChallenge.Models.ContactsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
