#pragma checksum "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37674debcfb73076475d405b622080e8995b17ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_AllPendingRequest), @"mvc.1.0.view", @"/Views/Request/AllPendingRequest.cshtml")]
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
#line 1 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\_ViewImports.cshtml"
using eCar_Rental_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\_ViewImports.cshtml"
using eCar_Rental_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\_ViewImports.cshtml"
using eCar_Rental_System.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37674debcfb73076475d405b622080e8995b17ae", @"/Views/Request/AllPendingRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3331fa9d78697ac772328f85e354a071b743b48f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Request_AllPendingRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eCar_Rental_System.Models.Request>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Request", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeclineRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml"
  
    ViewData["Title"] = "All Requests";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Pending Requests</h1>\r\n<hr />\r\n\r\n");
#nullable restore
#line 9 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <center><h1>No Pending Request !!</h1></center>\r\n");
#nullable restore
#line 12 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th class=""col-lg-2 col-md-6 col-sm-10"">Name</th>
                    <th class=""col-lg-2 col-md-6 col-sm-10"">Seat</th>
                    <th class=""col-lg-2 col-md-6 col-sm-10"">Starting Date</th>
                    <th class=""col-lg-2 col-md-6 col-sm-10"">Ending Date</th>
                    <th class=""col-lg-2 col-md-6 col-sm-10"">Status</th>
                    <th class=""col-lg-2 col-md-6 col-sm-10"">Action</th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 30 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml"
                 foreach (var request in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"col-lg-2 col-md-6 col-sm-10\">");
#nullable restore
#line 33 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml"
                                                           Write(request.car.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"col-lg-2 col-md-6 col-sm-10\">");
#nullable restore
#line 34 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml"
                                                           Write(request.car.No_Seat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"col-lg-2 col-md-6 col-sm-10\">");
#nullable restore
#line 35 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml"
                                                           Write(request.StartingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"col-lg-2 col-md-6 col-sm-10\">");
#nullable restore
#line 36 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml"
                                                           Write(request.EndingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"col-lg-2 col-md-6 col-sm-10\">");
#nullable restore
#line 37 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml"
                                                           Write(request.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"col-lg-2 col-md-6 col-sm-10\">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37674debcfb73076475d405b622080e8995b17ae9531", async() => {
                WriteLiteral("Accept");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml"
                                                                                                          WriteLiteral(request.Id);

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
            WriteLiteral("\r\n                            &nbsp;\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37674debcfb73076475d405b622080e8995b17ae12188", async() => {
                WriteLiteral("Decline");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml"
                                                                                                           WriteLiteral(request.Id);

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
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 46 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\User\Desktop\eCarRentalSystem_DotNetCoreMVC\DotNetCoreMVCProject_CE032_CE003\eCar-Rental-System\eCar-Rental-System\Views\Request\AllPendingRequest.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eCar_Rental_System.Models.Request>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
