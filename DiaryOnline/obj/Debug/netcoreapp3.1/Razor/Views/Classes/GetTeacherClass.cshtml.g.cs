#pragma checksum "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edb05601e1330c53902a2aed36031f0297553c2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classes_GetTeacherClass), @"mvc.1.0.view", @"/Views/Classes/GetTeacherClass.cshtml")]
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
#line 1 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\_ViewImports.cshtml"
using DiaryOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\_ViewImports.cshtml"
using DiaryOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb05601e1330c53902a2aed36031f0297553c2e", @"/Views/Classes/GetTeacherClass.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dce2012dec3e7ec3fe54366946eb5bfa71bb7a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Classes_GetTeacherClass : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DiaryClassDataLayer.ViewModels.NavigationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
  
    ViewData["Title"] = "GetTeacherClass";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12 mx-auto\">\r\n            <div class=\"card text-center\">\r\n                <div class=\"card-body\">\r\n                    <div class=\"card-title\"><h4>  ");
#nullable restore
#line 12 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
                                             Write(Model.Class.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n                    <div class=\"card-title\"><h4>  ");
#nullable restore
#line 13 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
                                             Write(Model.Class.ClassLead.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
                                                                         Write(Model.Class.ClassLead.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-6 text-center\">\r\n            <h4>Учителя</h4>\r\n");
#nullable restore
#line 23 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
             foreach (var item in Model.TeachersInClassInClass)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <div class=\"card-title\">\r\n                            ");
#nullable restore
#line 28 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
                                  Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 32 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div class=\"col-6 text-center\">\r\n            <h4>Ученики</h4>\r\n");
#nullable restore
#line 37 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
             foreach (var item in Model.UsersInClass)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <div class=\"card-title\">\r\n                            ");
#nullable restore
#line 42 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 42 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
                                  Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1427, "\"", 1541, 6);
            WriteAttributeValue("", 1434, "/Journal/AddRating?userId=", 1434, 26, true);
#nullable restore
#line 44 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
WriteAttributeValue("", 1460, item.Id, 1460, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1468, "&&teacherId=", 1468, 12, true);
#nullable restore
#line 44 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
WriteAttributeValue("", 1480, Guid.Parse(User.Identity.Name), 1480, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1511, "&&classId=", 1511, 10, true);
#nullable restore
#line 44 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"
WriteAttributeValue("", 1521, Model.Class.ClassId, 1521, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Поставить оценку</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 47 "D:\Projects\DiaryOnlineRepository\DiaryOnline\Views\Classes\GetTeacherClass.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DiaryClassDataLayer.ViewModels.NavigationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
