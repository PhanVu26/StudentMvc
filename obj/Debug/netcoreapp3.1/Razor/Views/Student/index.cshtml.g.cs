#pragma checksum "E:\Năm 4\KTHDV\StudentMvc\Views\Student\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ddecd13ef0fd3c2ad0ca7153d2432c6448aef75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_index), @"mvc.1.0.view", @"/Views/Student/index.cshtml")]
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
#line 1 "E:\Năm 4\KTHDV\StudentMvc\Views\_ViewImports.cshtml"
using StudentMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Năm 4\KTHDV\StudentMvc\Views\_ViewImports.cshtml"
using StudentMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ddecd13ef0fd3c2ad0ca7153d2432c6448aef75", @"/Views/Student/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b17de4c04b733654b87c48ffa8776674de8ba656", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Năm 4\KTHDV\StudentMvc\Views\Student\index.cshtml"
    
    ViewData["title"] = "Student page";
    List<Student> students =  Model;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Student</h1>
<p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Iusto aspernatur praesentium fuga architecto odit reiciendis sequi enim dignissimos eius, quidem laboriosam! Voluptatum doloribus ipsam doloremque beatae. Fugit cumque accusamus omnis.</p>
<a href=""student/AddStudent"" class=""btn btn-primary mb-2"">Add new Student</a>
<table class=""table table-hover"">
  <thead>
    <tr>
      <th scope=""col"">ID</th>
      <th scope=""col"">Name</th>
      <th scope=""col"">Age</th>
      <th scope=""col"">Address</th>
      <th scope=""col"">Option</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 21 "E:\Năm 4\KTHDV\StudentMvc\Views\Student\index.cshtml"
     foreach (var student in students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "E:\Năm 4\KTHDV\StudentMvc\Views\Student\index.cshtml"
           Write(student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "E:\Năm 4\KTHDV\StudentMvc\Views\Student\index.cshtml"
           Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "E:\Năm 4\KTHDV\StudentMvc\Views\Student\index.cshtml"
           Write(student.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "E:\Năm 4\KTHDV\StudentMvc\Views\Student\index.cshtml"
           Write(student.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 962, "\"", 1004, 2);
            WriteAttributeValue("", 969, "/student/EditStudent?id=", 969, 24, true);
#nullable restore
#line 29 "E:\Năm 4\KTHDV\StudentMvc\Views\Student\index.cshtml"
WriteAttributeValue("", 993, student.Id, 993, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1058, "\"", 1102, 2);
            WriteAttributeValue("", 1065, "/student/DeleteStudent?id=", 1065, 26, true);
#nullable restore
#line 30 "E:\Năm 4\KTHDV\StudentMvc\Views\Student\index.cshtml"
WriteAttributeValue("", 1091, student.Id, 1091, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n            </td>\r\n        </tr> \r\n");
#nullable restore
#line 33 "E:\Năm 4\KTHDV\StudentMvc\Views\Student\index.cshtml"
    }  

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
