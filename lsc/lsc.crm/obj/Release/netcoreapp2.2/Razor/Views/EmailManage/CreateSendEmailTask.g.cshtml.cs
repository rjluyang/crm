#pragma checksum "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\CreateSendEmailTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ec42a8afd5973e5f8b93fd5986ad7dcd1be1586"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmailManage_CreateSendEmailTask), @"mvc.1.0.view", @"/Views/EmailManage/CreateSendEmailTask.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmailManage/CreateSendEmailTask.cshtml", typeof(AspNetCore.Views_EmailManage_CreateSendEmailTask))]
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
#line 1 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\CreateSendEmailTask.cshtml"
using lsc.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ec42a8afd5973e5f8b93fd5986ad7dcd1be1586", @"/Views/EmailManage/CreateSendEmailTask.cshtml")]
    public class Views_EmailManage_CreateSendEmailTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lsc.Model.SendEmailTask>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\CreateSendEmailTask.cshtml"
  
    ViewData["Title"] = "添加邮件发送任务";
    Layout = "~/Pages/_Layout.cshtml";
    List<EmailTemplate> list = ViewBag.list;

#line default
#line hidden
            BeginContext(182, 566, true);
            WriteLiteral(@"<fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 20px;"">
    <legend>添加邮件发送任务</legend>
</fieldset>
<div class=""layui-fluid"">
    <div class=""layui-row"">
        <div class=""layui-col-md6"">
            <form class=""layui-form"">
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">邮件模板</label>
                    <div class=""layui-input-block"">
                        <select name=""EmailTempId"" lay-verify=""required"" lay-search>
                            <option value="""" ></option>
");
            EndContext();
#line 21 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\CreateSendEmailTask.cshtml"
                             if (list!=null)
                            {
                                foreach (EmailTemplate emailTemplate in list)
                                {

#line default
#line hidden
            BeginContext(939, 43, true);
            WriteLiteral("                                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 982, "\"", 1009, 1);
#line 25 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\CreateSendEmailTask.cshtml"
WriteAttributeValue("", 990, emailTemplate.Id, 990, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1010, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(1014, 51, false);
#line 25 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\CreateSendEmailTask.cshtml"
                                                                     Write(emailTemplate.Id==ViewBag.emailtempId?"selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(1066, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1069, 19, false);
#line 25 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\CreateSendEmailTask.cshtml"
                                                                                                                            Write(emailTemplate.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1089, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 26 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\CreateSendEmailTask.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(1166, 1483, true);
            WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">任务名称</label>
                    <div class=""layui-input-block"">
                        <input class=""layui-input"" name=""TaskName"" required  lay-verify=""required"" placeholder=""请输入任务名称"" autocomplete=""off"" />
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">目标邮箱</label>
                    <div class=""layui-input-block"">
                        <input class=""layui-input"" name=""Email""  placeholder=""请输入目标邮箱"" autocomplete=""off"" />
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">是否对所有目标邮箱发送</label>
                    <div class=""layui-input-block"">
                        <input type=""checkbox"" name=""sendAll"" lay-skin=""sw");
            WriteLiteral(@"itch"">
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <div class=""layui-input-block"">
                        <button class=""layui-btn"" lay-submit lay-filter=""*"">提交任务并开始发送</button>
                        <button type=""reset"" class=""layui-btn layui-btn-primary"">重置</button>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2666, 856, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var layer;
        layui.use(['form', 'layer','element'], function () {
            var form = layui.form;
            var element = layui.element;
            layer = layer;

            form.on('submit(*)', function (data) {

                $.post('/EmailManage/SaveSendEmailTask',
                    data.field,
                    function(res) {
                        if (res.code == 1) {
                            layer.msg('邮件已经开始发送', { icon: 6 });
                            window.location = '/EmailManage/SendEmailTaskList';
                        } else {
                            layer.msg('任务保存失败', { icon: 5 });
                        }
                    });
                return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。
            });
        });

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lsc.Model.SendEmailTask> Html { get; private set; }
    }
}
#pragma warning restore 1591