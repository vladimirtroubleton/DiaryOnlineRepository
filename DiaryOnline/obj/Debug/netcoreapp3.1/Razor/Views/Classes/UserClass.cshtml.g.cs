#pragma checksum "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ba59043485a8228cf0f406d606e38283061df48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classes_UserClass), @"mvc.1.0.view", @"/Views/Classes/UserClass.cshtml")]
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
#line 1 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\_ViewImports.cshtml"
using DiaryOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\_ViewImports.cshtml"
using DiaryOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba59043485a8228cf0f406d606e38283061df48", @"/Views/Classes/UserClass.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dce2012dec3e7ec3fe54366946eb5bfa71bb7a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Classes_UserClass : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DiaryClassDataLayer.ViewModels.NavigationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
  
    ViewData["Title"] = "UserClass";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container"">
        <div class=""row text-center"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""card-title"">
                        Название класса:
                    </div>
                    <div class=""card-title"">
                        ");
#nullable restore
#line 15 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
                   Write(Model.Class.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"card-title\">\r\n                        Классный руководитель\r\n                    </div>\r\n                    <div class=\"card-title\">\r\n                        ");
#nullable restore
#line 21 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
                   Write(Model.Class.ClassLead.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
                                               Write(Model.Class.ClassLead.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n");
#nullable restore
#line 28 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
                 foreach (var student in Model.UsersInClass)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card text-center"">
                        <div class=""card-body"">
                            <div class=""card-title"">
                                Имя ученика
                            </div>
                            <div class=""card-title"">
                                ");
#nullable restore
#line 36 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
                           Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 36 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
                                         Write(student.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <div class=""card-title"">
                                Электронная почта ученика
                            </div>
                            <div class=""card-title"">
                                ");
#nullable restore
#line 42 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
                           Write(student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 46 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-6\">\r\n");
#nullable restore
#line 49 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
                 foreach (var teacher in Model.TeachersInClassInClass)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card text-center"">
                        <div class=""card-body"">
                            <div class=""card-title"">
                                Имя учителя
                            </div>
                            <div class=""card-title"">
                                ");
#nullable restore
#line 57 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
                           Write(teacher.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 57 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
                                         Write(teacher.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <div class=""card-title"">
                                Электронная почта учителя
                            </div>
                            <div class=""card-title"">
                                ");
#nullable restore
#line 63 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
                           Write(teacher.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 67 "C:\Users\it013\Desktop\DiaryOnlineProject\DiaryOnline\Views\Classes\UserClass.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
