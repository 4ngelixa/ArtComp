#pragma checksum "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d09685ab09cd7e6d34ef93805df00f8abea7c8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompetitionSubmission__ViewSubmission), @"mvc.1.0.view", @"/Views/CompetitionSubmission/_ViewSubmission.cshtml")]
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
#line 1 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\_ViewImports.cshtml"
using WEB2021Apr_P04_T4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\_ViewImports.cshtml"
using WEB2021Apr_P04_T4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d09685ab09cd7e6d34ef93805df00f8abea7c8f", @"/Views/CompetitionSubmission/_ViewSubmission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b1001c9b0173860d214acdb09c959a8e1ead650", @"/Views/_ViewImports.cshtml")]
    public class Views_CompetitionSubmission__ViewSubmission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WEB2021Apr_P04_T4.Models.CompetitionSubmission>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CompetitionSubmission", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
 if (Model.ToList().Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive"">
        <table id=""viewSubmission"" class=""table table-striped table-bordered"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Competitor ID</th>
                    <th>File Submitted</th>
                    <th>Date/Time Submitted</th>
                    <th>Ranking</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 17 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 20 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                       Write(item.CompetitorID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 22 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                              if (item.FileSubmitted == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p> NIL </p>");
#nullable restore
#line 23 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                                             }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                               Write(item.FileSubmitted);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                                                       
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 31 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                              if (@item.DateTimeFileUpload == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p> NIL </p>");
#nullable restore
#line 32 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                                             }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                               Write(item.DateTimeFileUpload.ToString());

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                                                                       
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 40 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                              if (@item.Ranking == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p> NIL </p>");
#nullable restore
#line 41 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                                             }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                               Write(item.Ranking.ToString());

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                                                            
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d09685ab09cd7e6d34ef93805df00f8abea7c8f10084", async() => {
                WriteLiteral("Edit Ranking");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                                 WriteLiteral(item.CompetitorID);

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
            WriteLiteral(" |\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d09685ab09cd7e6d34ef93805df00f8abea7c8f12521", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                                 WriteLiteral(item.CompetitorID);

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
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 59 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color:red\">No submissions found!</span>\r\n");
#nullable restore
#line 63 "C:\Users\angel\OneDrive\Desktop\NP\Sem 2.1\WEB ASG1\WEB2021Apr_P04_T4\Views\CompetitionSubmission\_ViewSubmission.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WEB2021Apr_P04_T4.Models.CompetitionSubmission>> Html { get; private set; }
    }
}
#pragma warning restore 1591