#pragma checksum "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "252b1af39c3d5272605e32b631a147dd85a696c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Beli_Index), @"mvc.1.0.view", @"/Views/Beli/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Beli/Index.cshtml", typeof(AspNetCore.Views_Beli_Index))]
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
#line 2 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"252b1af39c3d5272605e32b631a147dd85a696c9", @"/Views/Beli/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3efe918c13658fae758fbc71970ee80ead3ba85", @"/Views/_ViewImports.cshtml")]
    public class Views_Beli_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CloudDentist.Models.Beli>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/core/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/sweetalert2/sweetalert2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/jquery-validation/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
  
    ViewData["Title"] = "getdetailbeli";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(176, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "252b1af39c3d5272605e32b631a147dd85a696c95412", async() => {
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
            BeginContext(230, 246, true);
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n        function Delete(Id) {\r\n            alertify.confirm(\'Data Kategori\',\'Apakah anda yakin untuk menghapus data ini ?!\', function (e) {\r\n                if (e) {\r\n                    window.location.href = \'");
            EndContext();
            BeginContext(477, 27, false);
#line 12 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
                                       Write(Url.Action("Delete","Beli"));

#line default
#line hidden
            EndContext();
            BeginContext(504, 436, true);
            WriteLiteral(@"/' + Id;
                }
                else {
                     alertify.error(""You've clicked Cancel"");
                }
            }, null);

    }
          $("".clickable"").click(function(){
           window.location = $(this).data(""href"");
     });


</script>
<div class=""block"">
    <div class=""block-header block-header-default"">
        <h3 class=""block-title"">Pembelian<small></small></h3>
        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 940, "\"", 987, 1);
#line 29 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
WriteAttributeValue("", 947, Url.Action("TambaheditDataBeli","Beli"), 947, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(988, 137, true);
            WriteLiteral(" class=\"btn btn-primary bottom-buffer\" id=\"btn-add-pembelian\" style=\"float:right;\"><i class=\"fa fa-plus\"></i> Pembelian</a>\r\n    </div>\r\n");
            EndContext();
#line 31 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
     if (TempData["alert"] != null)
    {

#line default
#line hidden
            BeginContext(1169, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1177, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "252b1af39c3d5272605e32b631a147dd85a696c98510", async() => {
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
            BeginContext(1247, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1257, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "252b1af39c3d5272605e32b631a147dd85a696c99698", async() => {
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
            BeginContext(1331, 54, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Hapus Data!!\", \"");
            EndContext();
            BeginContext(1386, 17, false);
#line 36 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
                             Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1403, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 38 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1443, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 39 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
     if (TempData["success"] != null)
    {

#line default
#line hidden
            BeginContext(1489, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1497, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "252b1af39c3d5272605e32b631a147dd85a696c911834", async() => {
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
            BeginContext(1567, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1577, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "252b1af39c3d5272605e32b631a147dd85a696c913023", async() => {
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
            BeginContext(1651, 50, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Berhasil\", \"");
            EndContext();
            BeginContext(1702, 17, false);
#line 44 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
                         Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1719, 35, true);
            WriteLiteral("\", \"success\");\r\n        </script>\r\n");
            EndContext();
#line 46 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1761, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 47 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
     if (TempData["error"] != null)
    {

#line default
#line hidden
            BeginContext(1805, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1813, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "252b1af39c3d5272605e32b631a147dd85a696c915152", async() => {
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
            BeginContext(1883, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1893, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "252b1af39c3d5272605e32b631a147dd85a696c916341", async() => {
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
            BeginContext(1967, 47, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"ERROR\", \"");
            EndContext();
            BeginContext(2015, 17, false);
#line 52 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
                      Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(2032, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 54 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2072, 731, true);
            WriteLiteral(@"    <div class=""block-content block-content-full"">
        <!-- DataTables functionality is initialized with .js-dataTable-full-pagination class in js/pages/be_tables_datatables.min.js which was auto compiled from _es6/pages/be_tables_datatables.js -->
        <table class=""table table-bordered table-striped table-vcenter js-dataTable-full-pagination"">
            <thead>
                <tr>
                    <th>Pembelian</th>
                    <th>Tanggal</th>
                    <th>Nama Tenant</th>
                    <th>Keterangan</th>
                    <th>Total Pembelian</th>
                    <th class=""text-center"">Action</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 69 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
                 foreach (var item in Model)

                {

#line default
#line hidden
            BeginContext(2870, 48, true);
            WriteLiteral("                <tr>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2918, "\"", 3009, 1);
#line 73 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
WriteAttributeValue("", 2925, Url.Action("Index", "DetailBeli", new { id = item.IdBeli, Tanggal = item.Tanggal }), 2925, 84, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3010, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3012, 18, false);
#line 73 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
                                                                                                                  Write(item.NamaPembelian);

#line default
#line hidden
            EndContext();
            BeginContext(3030, 35, true);
            WriteLiteral("</a></td>\r\n                    <td>");
            EndContext();
            BeginContext(3066, 63, false);
#line 74 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
                   Write(Convert.ToString(string.Format("{0:dd/MM/yyyy}", item.Tanggal)));

#line default
#line hidden
            EndContext();
            BeginContext(3129, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3161, 22, false);
#line 75 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
                   Write(item.Tenant.TenantName);

#line default
#line hidden
            EndContext();
            BeginContext(3183, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3215, 15, false);
#line 76 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
                   Write(item.Keterangan);

#line default
#line hidden
            EndContext();
            BeginContext(3230, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3262, 15, false);
#line 77 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
                   Write(item.TotalHarga);

#line default
#line hidden
            EndContext();
            BeginContext(3277, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(3531, 83, true);
            WriteLiteral("                    <td class=\"d-none d-sm-table-cell\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3614, "\"", 3688, 1);
#line 81 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
WriteAttributeValue("", 3621, Url.Action("TambahEditDataBeli", "Beli", new { id = item.IdBeli }), 3621, 67, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3689, 120, true);
            WriteLiteral(" class=\"btn btn-sm btn-secondary m-5\"><i class=\"fa fa-pencil text-primary mr-5\">Edit</i></a>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3809, "\"", 3839, 3);
            WriteAttributeValue("", 3819, "Delete(", 3819, 7, true);
#line 82 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
WriteAttributeValue("", 3826, item.IdBeli, 3826, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 3838, ")", 3838, 1, true);
            EndWriteAttribute();
            BeginContext(3840, 155, true);
            WriteLiteral(" class=\"float-sm-right btn-sm btn-secondary m-5\"><i class=\"fa fa-times text-danger mr-5\">Delete</i></a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 85 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Beli\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4014, 64, true);
            WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4095, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4101, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "252b1af39c3d5272605e32b631a147dd85a696c923678", async() => {
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
                BeginContext(4185, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4191, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "252b1af39c3d5272605e32b631a147dd85a696c924934", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4254, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(4259, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CloudDentist.Models.Beli>> Html { get; private set; }
    }
}
#pragma warning restore 1591
