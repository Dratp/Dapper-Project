#pragma checksum "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\EditQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f98adae0d86678756a8ac6b511727a7e1a9399d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QA_EditQuestion), @"mvc.1.0.view", @"/Views/QA/EditQuestion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QA/EditQuestion.cshtml", typeof(AspNetCore.Views_QA_EditQuestion))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f98adae0d86678756a8ac6b511727a7e1a9399d", @"/Views/QA/EditQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e5a985084eba6a87f5f5a7756ec7c1601d37e2", @"/Views/_ViewImports.cshtml")]
    public class Views_QA_EditQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Questions>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Help", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Errors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Discussion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Fun", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/QA/UpdateQuestion"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\EditQuestion.cshtml"
  
    ViewData["Title"] = "EditQuestion";

#line default
#line hidden
            BeginContext(66, 25, true);
            WriteLiteral("\r\n<b style=\"color:green\">");
            EndContext();
            BeginContext(92, 15, false);
#line 6 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\EditQuestion.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(107, 34, true);
            WriteLiteral("</b>\r\n\r\n<h2>Edit Question</h2>\r\n\r\n");
            EndContext();
            BeginContext(141, 753, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f98adae0d86678756a8ac6b511727a7e1a9399d5887", async() => {
                BeginContext(189, 44, true);
                WriteLiteral("\r\n    Title: <input type=\"text\" name=\"Title\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 233, "\"", 253, 1);
#line 11 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\EditQuestion.cshtml"
WriteAttributeValue("", 241, Model.Title, 241, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(254, 51, true);
                WriteLiteral(" /> <br />\r\n\r\n    Details: <textarea name=\"Detail\">");
                EndContext();
                BeginContext(306, 12, false);
#line 13 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\EditQuestion.cshtml"
                                Write(Model.Detail);

#line default
#line hidden
                EndContext();
                BeginContext(318, 73, true);
                WriteLiteral("</textarea> <br />\r\n\r\n    Category: <select name=\"Category\" id=\"Category\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 391, "\"", 414, 1);
#line 15 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\EditQuestion.cshtml"
WriteAttributeValue("", 399, Model.Category, 399, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(415, 11, true);
                WriteLiteral(">\r\n        ");
                EndContext();
                BeginContext(426, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f98adae0d86678756a8ac6b511727a7e1a9399d7657", async() => {
                    BeginContext(447, 11, true);
                    WriteLiteral("Coding Help");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(467, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(477, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f98adae0d86678756a8ac6b511727a7e1a9399d9133", async() => {
                    BeginContext(500, 6, true);
                    WriteLiteral("Errors");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(515, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(525, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f98adae0d86678756a8ac6b511727a7e1a9399d10603", async() => {
                    BeginContext(552, 10, true);
                    WriteLiteral("Discussion");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(571, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(581, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f98adae0d86678756a8ac6b511727a7e1a9399d12079", async() => {
                    BeginContext(601, 9, true);
                    WriteLiteral("Fun stuff");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(619, 65, true);
                WriteLiteral("\r\n    </select><br />\r\n\r\n    Tags: <input type=\"text\" name=\"Tags\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 684, "\"", 703, 1);
#line 22 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\EditQuestion.cshtml"
WriteAttributeValue("", 692, Model.Tags, 692, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(704, 47, true);
                WriteLiteral(" />\r\n\r\n    <input type=\"hidden\" name=\"Username\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 751, "\"", 774, 1);
#line 24 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\EditQuestion.cshtml"
WriteAttributeValue("", 759, Model.Username, 759, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(775, 39, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"ID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 814, "\"", 831, 1);
#line 25 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\EditQuestion.cshtml"
WriteAttributeValue("", 822, Model.ID, 822, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(832, 55, true);
                WriteLiteral(" />\r\n    \r\n    <input type=\"submit\" value=\"Submit\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(894, 5, true);
            WriteLiteral(" \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Questions> Html { get; private set; }
    }
}
#pragma warning restore 1591
