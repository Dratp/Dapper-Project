#pragma checksum "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9953ad3d8d2469e686372129ece0dacde2e87a1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QA_ReadAnswers), @"mvc.1.0.view", @"/Views/QA/ReadAnswers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QA/ReadAnswers.cshtml", typeof(AspNetCore.Views_QA_ReadAnswers))]
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
#line 1 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\_ViewImports.cshtml"
using Dapper_Project;

#line default
#line hidden
#line 2 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\_ViewImports.cshtml"
using Dapper_Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9953ad3d8d2469e686372129ece0dacde2e87a1b", @"/Views/QA/ReadAnswers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e5a985084eba6a87f5f5a7756ec7c1601d37e2", @"/Views/_ViewImports.cshtml")]
    public class Views_QA_ReadAnswers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Thread>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
  
    ViewData["Title"] = "ReadAnswers";

#line default
#line hidden
            BeginContext(64, 31, true);
            WriteLiteral("\r\n<h2>Read Answers</h2>\r\n\r\n<h3>");
            EndContext();
            BeginContext(96, 13, false);
#line 9 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
Write(Model.Q.Title);

#line default
#line hidden
            EndContext();
            BeginContext(109, 22, true);
            WriteLiteral("</h3>\r\n<h4>Posted by: ");
            EndContext();
            BeginContext(132, 16, false);
#line 10 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
          Write(Model.Q.Username);

#line default
#line hidden
            EndContext();
            BeginContext(148, 21, true);
            WriteLiteral("</h4>\r\n<h6>Category: ");
            EndContext();
            BeginContext(170, 16, false);
#line 11 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
         Write(Model.Q.Category);

#line default
#line hidden
            EndContext();
            BeginContext(186, 18, true);
            WriteLiteral("</h6>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(205, 14, false);
#line 14 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
Write(Model.Q.Detail);

#line default
#line hidden
            EndContext();
            BeginContext(219, 30, true);
            WriteLiteral("\r\n</p>\r\n\r\nAnswers:\r\n<br />\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 249, "\"", 286, 2);
            WriteAttributeValue("", 256, "/QA/WriteAnswer?id=", 256, 19, true);
#line 19 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
WriteAttributeValue("", 275, Model.Q.ID, 275, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(287, 45, true);
            WriteLiteral("> Add an Answer:  </a>\r\n<br />\r\n\r\n<table>\r\n\r\n");
            EndContext();
#line 24 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
     foreach (Answers a in Model.A)
    {

#line default
#line hidden
            BeginContext(376, 40, true);
            WriteLiteral("    <tr>\r\n\r\n\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(417, 8, false);
#line 30 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
       Write(a.Detail);

#line default
#line hidden
            EndContext();
            BeginContext(425, 58, true);
            WriteLiteral("\r\n\r\n        </td>\r\n\r\n        <td>\r\n            Posted by: ");
            EndContext();
            BeginContext(484, 10, false);
#line 35 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
                  Write(a.Username);

#line default
#line hidden
            EndContext();
            BeginContext(494, 56, true);
            WriteLiteral("\r\n        </td>\r\n\r\n        <td>\r\n            Posted at: ");
            EndContext();
            BeginContext(551, 8, false);
#line 39 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
                  Write(a.Posted);

#line default
#line hidden
            EndContext();
            BeginContext(559, 57, true);
            WriteLiteral("\r\n        </td>\r\n\r\n        <td>\r\n             Upvotes: <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 616, "\"", 654, 2);
            WriteAttributeValue("", 623, "/QA/UpVoteAnswer?answerID=", 623, 26, true);
#line 43 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
WriteAttributeValue("", 649, a.ID, 649, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(655, 22, true);
            WriteLiteral("> <input type=\"button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 677, "\"", 695, 1);
#line 43 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
WriteAttributeValue("", 685, a.UpVotes, 685, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(696, 26, true);
            WriteLiteral("/> </a>\r\n        </td>\r\n\r\n");
            EndContext();
#line 46 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
         if (ViewBag.username == a.Username || ViewBag.username == Model.Q.Username)
        {

#line default
#line hidden
            BeginContext(819, 36, true);
            WriteLiteral("            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 855, "\"", 891, 2);
            WriteAttributeValue("", 862, "/QA/RemoveAnswer?thisID=", 862, 24, true);
#line 49 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
WriteAttributeValue("", 886, a.ID, 886, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(892, 32, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n");
            EndContext();
#line 51 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
        }

#line default
#line hidden
            BeginContext(935, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 53 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"

    }

#line default
#line hidden
            BeginContext(959, 14, true);
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Thread> Html { get; private set; }
    }
}
#pragma warning restore 1591
