#pragma checksum "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7c103439e5f70f037c54a1a79a1d8db788a6e81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Issue_Details), @"mvc.1.0.view", @"/Views/Issue/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Issue/Details.cshtml", typeof(AspNetCore.Views_Issue_Details))]
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
#line 1 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\_ViewImports.cshtml"
using UrbanSolution.Web;

#line default
#line hidden
#line 2 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\_ViewImports.cshtml"
using UrbanSolution.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\_ViewImports.cshtml"
using UrbanSolution.Web.Infrastructure;

#line default
#line hidden
#line 4 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\_ViewImports.cshtml"
using UrbanSolution.Services.Models;

#line default
#line hidden
#line 5 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 6 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c103439e5f70f037c54a1a79a1d8db788a6e81", @"/Views/Issue/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be5e81d224dfaffe42d33523091dd56dc93853f", @"/Views/_ViewImports.cshtml")]
    public class Views_Issue_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UrbanIssueDetailsServiceModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Manager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Issues", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Approve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
  
    ViewData["Title"] = $"Details for {Model.Name} issue";
    var apiKey = Configuration.GetSection("Google:MapsApiKey").Value;    //TODO: remove after partial/component

#line default
#line hidden
            BeginContext(258, 59, true);
            WriteLiteral("\r\n<div row class=\"text-info\">\r\n    <h3 class=\"text-center\">");
            EndContext();
            BeginContext(318, 22, false);
#line 10 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
                       Write(this.ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(340, 147, true);
            WriteLiteral("</h3>\r\n    <hr />\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"form-group col-xs-6\">\r\n        <div class=\"row\">\r\n            <h3>Published by <em>");
            EndContext();
            BeginContext(488, 15, false);
#line 17 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
                            Write(Model.Publisher);

#line default
#line hidden
            EndContext();
            BeginContext(503, 13, true);
            WriteLiteral("</em> on <em>");
            EndContext();
            BeginContext(517, 37, false);
#line 17 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
                                                         Write(Model.PublishedOn.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(554, 41, true);
            WriteLiteral("</em></h3>\r\n            <h3>Description: ");
            EndContext();
            BeginContext(596, 17, false);
#line 18 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
                        Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(613, 23, true);
            WriteLiteral("</h3>\r\n            <h3>");
            EndContext();
            BeginContext(637, 19, false);
#line 19 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
           Write(Model.AddressStreet);

#line default
#line hidden
            EndContext();
            BeginContext(656, 8, true);
            WriteLiteral(" street ");
            EndContext();
            BeginContext(665, 18, false);
#line 19 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
                                       Write(Model.StreetNumber);

#line default
#line hidden
            EndContext();
            BeginContext(683, 29, true);
            WriteLiteral("</h3>\r\n            <h3>Type: ");
            EndContext();
            BeginContext(713, 10, false);
#line 20 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
                 Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(723, 31, true);
            WriteLiteral("</h3>\r\n            <h3>Region: ");
            EndContext();
            BeginContext(755, 12, false);
#line 21 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
                   Write(Model.Region);

#line default
#line hidden
            EndContext();
            BeginContext(767, 23, true);
            WriteLiteral("</h3>\r\n            <h4>");
            EndContext();
            BeginContext(792, 51, false);
#line 22 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
            Write(Model.IsApproved != true ? "Not approved yet!" : "");

#line default
#line hidden
            EndContext();
            BeginContext(844, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 23 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
             if (Model.HasResolved)
            {

#line default
#line hidden
            BeginContext(903, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(921, 25, true);
            WriteLiteral("(View Resolved:) <a></a> ");
            EndContext();
            BeginContext(979, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(996, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 27 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
             if (this.User.IsInRole(WebConstants.ManagerRole))
            {
                if (!Model.IsApproved)
                {

#line default
#line hidden
            BeginContext(1134, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1154, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8295c51c029342dd83431c18aa0ead60", async() => {
                BeginContext(1270, 7, true);
                WriteLiteral("Approve");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
                                                                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1281, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1302, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1318, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f100c0ca4ac14eee8c9a972dc68394c3", async() => {
                BeginContext(1431, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
                                                                                                          WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1439, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1457, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27558b0c6dc04a57b32189fc0f552377", async() => {
                BeginContext(1572, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(" ");
#line 34 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
                                                                                                            WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1582, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1599, 159, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"form-group col-xs-6\">\r\n        <div class=\"row\">\r\n            <div id=\"map\" style=\"height: 400px; width: 600px;\">\r\n");
            EndContext();
            BeginContext(1814, 60, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1892, 102, true);
                WriteLiteral("\r\n  \r\n    <script>\r\n        var map;\r\n        function initMap() {\r\n            var myLatLng = { lat: ");
                EndContext();
                BeginContext(1996, 14, false);
#line 53 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
                              Write(Model.Latitude);

#line default
#line hidden
                EndContext();
                BeginContext(2011, 7, true);
                WriteLiteral(", lng: ");
                EndContext();
                BeginContext(2020, 15, false);
#line 53 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
                                                      Write(Model.Longitude);

#line default
#line hidden
                EndContext();
                BeginContext(2036, 273, true);
                WriteLiteral(@" };
            var mapOptions = { zoom: 17, center: myLatLng }
            map = new google.maps.Map(document.getElementById('map'), mapOptions);
            var marker = new google.maps.Marker({ position: myLatLng, map: map });
        }
    </script>

    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2309, "\"", 2385, 3);
                WriteAttributeValue("", 2315, "https://maps.googleapis.com/maps/api/js?key=", 2315, 44, true);
#line 60 "C:\Users\Ivaylo\source\repos\UrbanSolution\UrbanSolution.Web\Views\Issue\Details.cshtml"
WriteAttributeValue("", 2359, apiKey, 2359, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 2368, "&callback=initMap", 2368, 17, true);
                EndWriteAttribute();
                BeginContext(2386, 43, true);
                WriteLiteral("\r\n            async defer>\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UrbanIssueDetailsServiceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591