#pragma checksum "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ad63f1a612b9c7759bed4c9b1647509272a022"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Barang_barangtenantid), @"mvc.1.0.view", @"/Views/Barang/barangtenantid.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Barang/barangtenantid.cshtml", typeof(AspNetCore.Views_Barang_barangtenantid))]
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
#line 2 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ad63f1a612b9c7759bed4c9b1647509272a022", @"/Views/Barang/barangtenantid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3efe918c13658fae758fbc71970ee80ead3ba85", @"/Views/_ViewImports.cshtml")]
    public class Views_Barang_barangtenantid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CloudDentist.Models.Barang>>
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
#line 3 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
  
    ViewData["Title"] = "barangtenantid";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(179, 244, true);
            WriteLiteral("<script type=\"text/javascript\">\r\n        function Delete(Id) {\r\n            alertify.confirm(\'Data Kategori\',\'Apakah anda yakin untuk menghapus data ini ?!\', function (e) {\r\n                if (e) {\r\n                    window.location.href = \'");
            EndContext();
            BeginContext(424, 29, false);
#line 11 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
                                       Write(Url.Action("Delete","Barang"));

#line default
#line hidden
            EndContext();
            BeginContext(453, 211, true);
            WriteLiteral("/\' + Id;\r\n                }\r\n                else {\r\n                     alertify.error(\"You\'ve clicked Cancel\");\r\n                }\r\n            }, null);\r\n\r\n        }\r\n\r\n</script>\r\n<h5>Pengaturan Data Barang ");
            EndContext();
            BeginContext(665, 35, false);
#line 21 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
                      Write(Context.Session.GetString("Tenant"));

#line default
#line hidden
            EndContext();
            BeginContext(700, 266, true);
            WriteLiteral(@"</h5>
<p>Fasilitas ini digunakan untuk mengolah data Barang ke dalam sistem</p>
<!-- Dynamic Table Full Pagination -->
<div class=""block"">
    <div class=""block-header block-header-default"">
        <h3 class=""block-title"">Barang<small></small></h3>
        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 966, "\"", 1017, 1);
#line 27 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
WriteAttributeValue("", 973, Url.Action("TambahEditDataBarang","Barang"), 973, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1018, 135, true);
            WriteLiteral(" class=\"btn btn-primary bottom-buffer\" id=\"btn-add-databarang\" style=\"float:right;\"><i class=\"fa fa-plus\"></i> Barang</a>\r\n    </div>\r\n");
            EndContext();
#line 29 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
     if (TempData["alert"] != null)
    {

#line default
#line hidden
            BeginContext(1197, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1205, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ad63f1a612b9c7759bed4c9b1647509272a0227635", async() => {
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
            BeginContext(1275, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1285, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ad63f1a612b9c7759bed4c9b1647509272a0228823", async() => {
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
            BeginContext(1359, 54, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Hapus Data!!\", \"");
            EndContext();
            BeginContext(1414, 17, false);
#line 34 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
                             Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1431, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 36 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
    }

#line default
#line hidden
            BeginContext(1471, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 37 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
     if (TempData["success"] != null)
    {

#line default
#line hidden
            BeginContext(1517, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1525, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ad63f1a612b9c7759bed4c9b1647509272a02210992", async() => {
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
            BeginContext(1595, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1605, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ad63f1a612b9c7759bed4c9b1647509272a02212181", async() => {
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
            BeginContext(1679, 50, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Berhasil\", \"");
            EndContext();
            BeginContext(1730, 17, false);
#line 42 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
                         Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1747, 35, true);
            WriteLiteral("\", \"success\");\r\n        </script>\r\n");
            EndContext();
#line 44 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
    }

#line default
#line hidden
            BeginContext(1789, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 45 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
     if (TempData["error"] != null)
    {

#line default
#line hidden
            BeginContext(1833, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1841, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ad63f1a612b9c7759bed4c9b1647509272a02214343", async() => {
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
            BeginContext(1911, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1921, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ad63f1a612b9c7759bed4c9b1647509272a02215532", async() => {
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
            BeginContext(1995, 47, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"ERROR\", \"");
            EndContext();
            BeginContext(2043, 17, false);
#line 50 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
                      Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(2060, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 52 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
    }

#line default
#line hidden
            BeginContext(2100, 761, true);
            WriteLiteral(@"    <div class=""block-content block-content-full"">
        <!-- DataTables functionality is initialized with .js-dataTable-full-pagination class in js/pages/be_tables_datatables.min.js which was auto compiled from _es6/pages/be_tables_datatables.js -->
        <table class=""table table-bordered table-striped table-vcenter js-dataTable-full-pagination"">
            <thead>
                <tr>
                    <th>Nama Barang</th>
                    <th>Nama Kategori</th>
                    <th>Stok</th>
                    <th>Min Stok</th>
                    <th>Harga</th>
                    <th>Keterangan</th>
                    <th class=""text-center"">Action</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 68 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
                 foreach (var item in Model)

                {

#line default
#line hidden
            BeginContext(2928, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2983, 15, false);
#line 72 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
                       Write(item.NamaBarang);

#line default
#line hidden
            EndContext();
            BeginContext(2998, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3034, 27, false);
#line 73 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
                       Write(item.KatBarang.NamaKategori);

#line default
#line hidden
            EndContext();
            BeginContext(3061, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3097, 9, false);
#line 74 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
                       Write(item.Stok);

#line default
#line hidden
            EndContext();
            BeginContext(3106, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3142, 12, false);
#line 75 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
                       Write(item.Minstok);

#line default
#line hidden
            EndContext();
            BeginContext(3154, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3190, 10, false);
#line 76 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
                       Write(item.Harga);

#line default
#line hidden
            EndContext();
            BeginContext(3200, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3236, 15, false);
#line 77 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
                       Write(item.Keterangan);

#line default
#line hidden
            EndContext();
            BeginContext(3251, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(3529, 91, true);
            WriteLiteral("                        <td class=\"d-none d-sm-table-cell\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3620, "\"", 3750, 1);
#line 81 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
WriteAttributeValue("", 3627, Url.Action("TambahEditDataBarang", "Barang", new { id = item.IdBarang, TenantID = Context.Session.GetString("TenantID") }), 3627, 123, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3751, 124, true);
            WriteLiteral(" class=\"btn btn-sm btn-secondary m-5\"><i class=\"fa fa-pencil text-primary mr-5\">Edit</i></a>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3875, "\"", 3907, 3);
            WriteAttributeValue("", 3885, "Delete(", 3885, 7, true);
#line 82 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
WriteAttributeValue("", 3892, item.IdBarang, 3892, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 3906, ")", 3906, 1, true);
            EndWriteAttribute();
            BeginContext(3908, 163, true);
            WriteLiteral(" class=\"float-sm-right btn-sm btn-secondary m-5\"><i class=\"fa fa-times text-danger mr-5\">Delete</i></a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 85 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Barang\barangtenantid.cshtml"
                }

#line default
#line hidden
            BeginContext(4090, 64, true);
            WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4171, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4177, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ad63f1a612b9c7759bed4c9b1647509272a02222905", async() => {
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
                BeginContext(4261, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4267, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ad63f1a612b9c7759bed4c9b1647509272a02224161", async() => {
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
                BeginContext(4330, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(4335, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CloudDentist.Models.Barang>> Html { get; private set; }
    }
}
#pragma warning restore 1591