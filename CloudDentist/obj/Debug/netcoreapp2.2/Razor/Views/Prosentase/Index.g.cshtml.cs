#pragma checksum "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f5047f1c890453666604ffc62657628632caa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prosentase_Index), @"mvc.1.0.view", @"/Views/Prosentase/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Prosentase/Index.cshtml", typeof(AspNetCore.Views_Prosentase_Index))]
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
#line 1 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\_ViewImports.cshtml"
using CloudDentist;

#line default
#line hidden
#line 2 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\_ViewImports.cshtml"
using CloudDentist.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f5047f1c890453666604ffc62657628632caa0", @"/Views/Prosentase/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3efe918c13658fae758fbc71970ee80ead3ba85", @"/Views/_ViewImports.cshtml")]
    public class Views_Prosentase_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CloudDentist.Models.Prosentase>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/sweetalert2/sweetalert2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/jquery-validation/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 246, true);
            WriteLiteral("<script type=\"text/javascript\">\r\n        function Delete(Id) {\r\n            alertify.confirm(\'Data Prosentase\',\'Apakah anda yakin untuk menghapus data ini ?!\', function (e) {\r\n                if (e) {\r\n                    window.location.href = \'");
            EndContext();
            BeginContext(387, 33, false);
#line 10 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
                                       Write(Url.Action("Delete","Prosentase"));

#line default
#line hidden
            EndContext();
            BeginContext(420, 379, true);
            WriteLiteral(@"/' + Id;
                }
                else {
                     alertify.error(""You've clicked Cancel"");
                }
            }, null);

        }

</script>
<!-- Dynamic Table Full Pagination -->
<div class=""block"">
    <div class=""block-header block-header-default"">
        <h3 class=""block-title"">Master Prosentase<small></small></h3>
        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 799, "\"", 860, 1);
#line 24 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
WriteAttributeValue("", 806, Url.Action("Tambah_edit_dataprosentase","Prosentase"), 806, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(861, 139, true);
            WriteLiteral(" class=\"btn btn-primary bottom-buffer\" id=\"btn-add-databarang\" style=\"float:right;\"><i class=\"fa fa-plus\"></i> Prosentase</a>\r\n    </div>\r\n");
            EndContext();
#line 26 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
     if (TempData["alert"] != null)
    {

#line default
#line hidden
            BeginContext(1044, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1052, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f5047f1c890453666604ffc62657628632caa06936", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1122, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1132, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f5047f1c890453666604ffc62657628632caa08124", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1206, 54, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Hapus Data!!\", \"");
            EndContext();
            BeginContext(1261, 17, false);
#line 31 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
                             Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1278, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 33 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1318, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 34 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
     if (TempData["success"] != null)
    {

#line default
#line hidden
            BeginContext(1364, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1372, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f5047f1c890453666604ffc62657628632caa010278", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1442, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1452, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f5047f1c890453666604ffc62657628632caa011467", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1526, 50, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Berhasil\", \"");
            EndContext();
            BeginContext(1577, 17, false);
#line 39 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
                         Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1594, 35, true);
            WriteLiteral("\", \"success\");\r\n        </script>\r\n");
            EndContext();
#line 41 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1636, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 42 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
     if (TempData["error"] != null)
    {

#line default
#line hidden
            BeginContext(1680, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1688, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f5047f1c890453666604ffc62657628632caa013614", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1758, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1768, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f5047f1c890453666604ffc62657628632caa014803", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1842, 47, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"ERROR\", \"");
            EndContext();
            BeginContext(1890, 17, false);
#line 47 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
                      Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1907, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 49 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1947, 690, true);
            WriteLiteral(@"    <div class=""block-content block-content-full"">
        <!-- DataTables functionality is initialized with .js-dataTable-full-pagination class in js/pages/be_tables_datatables.min.js which was auto compiled from _es6/pages/be_tables_datatables.js -->
        <table class=""table table-bordered table-striped table-vcenter js-dataTable-full-pagination"">
            <thead>
                <tr>
                    <th>Nama Dokter</th>
                    <th>Jenis Tindakan</th>
                    <th>Prosen</th>
                    <th>Nama Tenant</th>
                    <th class=""text-center"">Action</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 63 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
                 foreach (var item in Model)

                {

#line default
#line hidden
            BeginContext(2704, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2759, 13, false);
#line 67 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
                       Write(item.Username);

#line default
#line hidden
            EndContext();
            BeginContext(2772, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2808, 24, false);
#line 68 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
                       Write(item.JenisTindakan.Jenis);

#line default
#line hidden
            EndContext();
            BeginContext(2832, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2868, 11, false);
#line 69 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
                       Write(item.Prosen);

#line default
#line hidden
            EndContext();
            BeginContext(2879, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2915, 22, false);
#line 70 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
                       Write(item.Tenant.TenantName);

#line default
#line hidden
            EndContext();
            BeginContext(2937, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
            BeginContext(3216, 91, true);
            WriteLiteral("                        <td class=\"d-none d-sm-table-cell\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3307, "\"", 3401, 1);
#line 74 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
WriteAttributeValue("", 3314, Url.Action("Tambah_edit_dataprosentase", "Prosentase", new { id = item.IdProsentase }), 3314, 87, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3402, 124, true);
            WriteLiteral(" class=\"btn btn-sm btn-secondary m-5\"><i class=\"fa fa-pencil text-primary mr-5\">Edit</i></a>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3526, "\"", 3562, 3);
            WriteAttributeValue("", 3536, "Delete(", 3536, 7, true);
#line 75 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
WriteAttributeValue("", 3543, item.IdProsentase, 3543, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 3561, ")", 3561, 1, true);
            EndWriteAttribute();
            BeginContext(3563, 163, true);
            WriteLiteral(" class=\"float-sm-right btn-sm btn-secondary m-5\"><i class=\"fa fa-times text-danger mr-5\">Delete</i></a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 78 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Prosentase\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3745, 64, true);
            WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3826, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3832, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f5047f1c890453666604ffc62657628632caa021256", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3916, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3922, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f5047f1c890453666604ffc62657628632caa022512", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3985, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(3990, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CloudDentist.Models.Prosentase>> Html { get; private set; }
    }
}
#pragma warning restore 1591
