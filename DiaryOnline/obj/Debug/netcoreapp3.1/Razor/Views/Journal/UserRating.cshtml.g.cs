#pragma checksum "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1e949f8c25d881a558b2afa008a57cf836d148b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Journal_UserRating), @"mvc.1.0.view", @"/Views/Journal/UserRating.cshtml")]
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
#line 1 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\_ViewImports.cshtml"
using DiaryOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\_ViewImports.cshtml"
using DiaryOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1e949f8c25d881a558b2afa008a57cf836d148b", @"/Views/Journal/UserRating.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dce2012dec3e7ec3fe54366946eb5bfa71bb7a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Journal_UserRating : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DiaryClassDataLayer.ViewModels.RatingViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml"
  
    ViewData["Title"] = "UserRating";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n\r\n\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n\r\n                   \r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 17 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml"
                   Write(Html.DisplayNameFor(model => model.SubjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 21 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml"
                   Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 25 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml"
                   Write(Html.DisplayNameFor(model => model.TeacherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 28 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml"
                   Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 31 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 37 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n\r\n\r\n                       \r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 45 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SubjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 49 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TeacherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 56 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 59 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 63 "D:\Release\DiaryOnlineRepository\DiaryOnline\Views\Journal\UserRating.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DiaryClassDataLayer.ViewModels.RatingViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
