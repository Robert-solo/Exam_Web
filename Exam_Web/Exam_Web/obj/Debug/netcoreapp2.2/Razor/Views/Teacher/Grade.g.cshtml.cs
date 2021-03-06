#pragma checksum "E:\proects\C#\Exam_Web\Exam_Web\Views\Teacher\Grade.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01a1170b61b3c488a879df73580001884cf6965d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Grade), @"mvc.1.0.view", @"/Views/Teacher/Grade.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Grade.cshtml", typeof(AspNetCore.Views_Teacher_Grade))]
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
#line 1 "E:\proects\C#\Exam_Web\Exam_Web\Views\_ViewImports.cshtml"
using Exam_Web;

#line default
#line hidden
#line 2 "E:\proects\C#\Exam_Web\Exam_Web\Views\_ViewImports.cshtml"
using Exam_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01a1170b61b3c488a879df73580001884cf6965d", @"/Views/Teacher/Grade.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3567e3a03284080c6dbff07d9c2cca999d572f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Grade : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\proects\C#\Exam_Web\Exam_Web\Views\Teacher\Grade.cshtml"
  
    ViewData["Title"] = "Grade";
    Layout = "~/Views/Shared/mian_layout.cshtml";
    var username = ViewBag.username as List<string>;
    var testname = ViewBag.Testname as List<string>;
    var grade = ViewBag.grade as List<Grade>;
    var i = 0;

#line default
#line hidden
            BeginContext(265, 1883, true);
            WriteLiteral(@"
<script>
    var id;
    function editgrade() {
        $.ajax({
            url: ""/Data/EditGrade"",
            type: ""post"",
            data: {
                ""S_mark"": $(""#Sel_A"").val(),
                ""A_mark"": $(""#Sel_B"").val(),
                ""G_mark"": $(""#Sel_C"").val(),
                ""id"": id,
            },
            success: function () {
                console.log(""ok!"");
            }
        })
    }

    function getgrade(_id) {
        id = _id;
        $.ajax({
            url: ""/Data/GetGrade"",
            type:""post"",
            data: {
                ""id"":id,
            },
            dataType: ""json"",
            success: function (a) {
                console.log(a);
                $(""#Sel_A"").val(a.s_mark);
                $(""#Sel_B"").val(a.a_mark);
                $(""#Sel_C"").val(a.mark);
            }
        })
    }
</script>

<div class=""row"">
    <div class=""col"">
        <div class=""card card-small mb-4"">
            <div class");
            WriteLiteral(@"=""card-header border-bottom"">
                <h6 class=""m-0"">成绩查询</h6>
            </div>
            <div class=""card-body p-0 pb-3 text-center"">
                <table class=""table mb-0"">
                    <thead class=""bg-light"">
                        <tr>
                            <th scope=""col"" class=""border-0"">学生</th>
                            <th scope=""col"" class=""border-0"">试卷名</th>
                            <th scope=""col"" class=""border-0"">班级</th>
                            <th scope=""col"" class=""border-0"">选择题</th>
                            <th scope=""col"" class=""border-0"">问答题</th>
                            <th scope=""col"" class=""border-0"">总分</th>
                            <th scope=""col"" class=""border-0"">试卷操作</th>

                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 69 "E:\proects\C#\Exam_Web\Exam_Web\Views\Teacher\Grade.cshtml"
                         foreach (var a in grade)
                        {

#line default
#line hidden
            BeginContext(2226, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2297, 11, false);
#line 72 "E:\proects\C#\Exam_Web\Exam_Web\Views\Teacher\Grade.cshtml"
                               Write(username[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2308, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2352, 11, false);
#line 73 "E:\proects\C#\Exam_Web\Exam_Web\Views\Teacher\Grade.cshtml"
                               Write(testname[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2363, 85, true);
            WriteLiteral("</td>\r\n                                <td></td>\r\n                                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2448, "\"", 2464, 2);
#line 75 "E:\proects\C#\Exam_Web\Exam_Web\Views\Teacher\Grade.cshtml"
WriteAttributeValue("", 2453, a.Gra_id, 2453, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2462, "+S", 2462, 2, true);
            EndWriteAttribute();
            BeginContext(2465, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2467, 8, false);
#line 75 "E:\proects\C#\Exam_Web\Exam_Web\Views\Teacher\Grade.cshtml"
                                                Write(a.S_mark);

#line default
#line hidden
            EndContext();
            BeginContext(2475, 42, true);
            WriteLiteral("</td>\r\n                                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2517, "\"", 2533, 2);
#line 76 "E:\proects\C#\Exam_Web\Exam_Web\Views\Teacher\Grade.cshtml"
WriteAttributeValue("", 2522, a.Gra_id, 2522, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2531, "+A", 2531, 2, true);
            EndWriteAttribute();
            BeginContext(2534, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2536, 8, false);
#line 76 "E:\proects\C#\Exam_Web\Exam_Web\Views\Teacher\Grade.cshtml"
                                                Write(a.A_mark);

#line default
#line hidden
            EndContext();
            BeginContext(2544, 42, true);
            WriteLiteral("</td>\r\n                                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2586, "\"", 2602, 2);
#line 77 "E:\proects\C#\Exam_Web\Exam_Web\Views\Teacher\Grade.cshtml"
WriteAttributeValue("", 2591, a.Gra_id, 2591, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2600, "+G", 2600, 2, true);
            EndWriteAttribute();
            BeginContext(2603, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2605, 6, false);
#line 77 "E:\proects\C#\Exam_Web\Exam_Web\Views\Teacher\Grade.cshtml"
                                                Write(a.mark);

#line default
#line hidden
            EndContext();
            BeginContext(2611, 177, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <input type=\"button\" class=\"btn btn-info\" value=\"编辑\"  data-toggle=\"modal\" data-target=\"#myModal\"");
            EndContext();
            BeginWriteAttribute("onclick", "  onclick=\"", 2788, "\"", 2818, 3);
            WriteAttributeValue("", 2799, "getgrade(", 2799, 9, true);
#line 79 "E:\proects\C#\Exam_Web\Exam_Web\Views\Teacher\Grade.cshtml"
WriteAttributeValue("", 2808, a.Gra_id, 2808, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2817, ")", 2817, 1, true);
            EndWriteAttribute();
            BeginContext(2819, 77, true);
            WriteLiteral(" />\r\n                                </td>\r\n                            </tr>");
            EndContext();
#line 81 "E:\proects\C#\Exam_Web\Exam_Web\Views\Teacher\Grade.cshtml"
                                 i++;
                        }

#line default
#line hidden
            BeginContext(2929, 408, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>


<div class=""modal fade "" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"" onload="""">
    <div class=""modal-dialog"" style=""width:1000px;height:1111px"">
        <div class=""modal-content"" style=""width:700px"">
            <div class=""modal-header"">
");
            EndContext();
            BeginContext(3451, 906, true);
            WriteLiteral(@"                <h4 class=""modal-title"" id=""myModalLabel"">修改信息</h4>
            </div>
                <div class=""modal-body"">
                    <div class=""row"" style=""margin-top:8px"">选择题分数：<input type=""text"" class=""input"" id=""Sel_A"" /></div>
                    <div class=""row"" style=""margin-top:8px"">问答题分数：<input type=""text"" class=""input"" id=""Sel_B"" /></div>
                    <div class=""row"" style=""margin-top:8px"">总分：<input type=""text""  class=""input"" id=""Sel_C"" /></div>                  
                    <div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">关闭</button>
                            <button type=""submit"" class=""btn btn-primary"" onclick=""editgrade()"" data-dismiss=""modal"">提交更改</button>
                        </div>
                    </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
