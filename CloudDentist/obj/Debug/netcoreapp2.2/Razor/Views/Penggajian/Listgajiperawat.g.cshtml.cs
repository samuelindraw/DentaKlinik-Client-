#pragma checksum "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeab79c139242b39e9c28326364a4f71a58008a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Penggajian_Listgajiperawat), @"mvc.1.0.view", @"/Views/Penggajian/Listgajiperawat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Penggajian/Listgajiperawat.cshtml", typeof(AspNetCore.Views_Penggajian_Listgajiperawat))]
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
#line 1 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeab79c139242b39e9c28326364a4f71a58008a3", @"/Views/Penggajian/Listgajiperawat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3efe918c13658fae758fbc71970ee80ead3ba85", @"/Views/_ViewImports.cshtml")]
    public class Views_Penggajian_Listgajiperawat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CloudDentist.Models.Penggajian>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/core/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/codebase.core.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/codebase.app.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/jquery-ui/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/sweetalert2/sweetalert2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/plugins/jquery-validation/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
  
    ViewData["Title"] = "Listgajiperawat";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(184, 240, true);
            WriteLiteral("<script type=\"text/javascript\">\r\n    function Delete(Id) {\r\n            alertify.confirm(\'Data Kategori\',\'Apakah anda yakin untuk menghapus data ini ?!\', function (e) {\r\n                if (e) {\r\n                    window.location.href = \'");
            EndContext();
            BeginContext(425, 33, false);
#line 11 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
                                       Write(Url.Action("Delete","Penggajian"));

#line default
#line hidden
            EndContext();
            BeginContext(458, 182, true);
            WriteLiteral("/\' + Id;\r\n                }\r\n                else {\r\n                     alertify.error(\"You\'ve clicked Cancel\");\r\n                }\r\n            }, null);\r\n\r\n        }\r\n</script>\r\n");
            EndContext();
            BeginContext(640, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a37638", async() => {
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
            BeginContext(694, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(696, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a38815", async() => {
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
            BeginContext(752, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(754, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a39992", async() => {
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
            BeginContext(809, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(811, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a311169", async() => {
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
            BeginContext(881, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(883, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a312347", async() => {
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
            BeginContext(953, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(955, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a313525", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1029, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1074, 68, true);
            WriteLiteral("<!-- Dynamic Table Full Pagination -->\r\n<h5>Pengaturan Gaji Perawat ");
            EndContext();
            BeginContext(1143, 35, false);
#line 28 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
                       Write(Context.Session.GetString("Tenant"));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 249, true);
            WriteLiteral("</h5>\r\n<p>Fasilitas ini digunakan untuk mengolah data gaji Perawat ke dalam sistem</p>\r\n<div class=\"block\">\r\n    <div class=\"block-header block-header-default\">\r\n        <h3 class=\"block-title\">Data Penggajian Perawat<small></small></h3>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1427, "\"", 1473, 1);
#line 33 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
WriteAttributeValue("", 1434, Url.Action("GajiPerawat","Penggajian"), 1434, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1474, 135, true);
            WriteLiteral(" class=\"btn btn-primary bottom-buffer\" id=\"btn-add-Gaji\" style=\"float:right;\"><i class=\"fa fa-plus\"></i> Gaji Perawat</a>\r\n    </div>\r\n");
            EndContext();
#line 35 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
     if (TempData["alert"] != null)
    {

#line default
#line hidden
            BeginContext(1653, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1661, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a316395", async() => {
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
            BeginContext(1731, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1741, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a317584", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1815, 54, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Hapus Data!!\", \"");
            EndContext();
            BeginContext(1870, 17, false);
#line 40 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
                             Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1887, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 42 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
    }

#line default
#line hidden
            BeginContext(1927, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 43 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
     if (TempData["success"] != null)
    {

#line default
#line hidden
            BeginContext(1973, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1981, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a319769", async() => {
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
            BeginContext(2051, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2061, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a320958", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2135, 50, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Berhasil\", \"");
            EndContext();
            BeginContext(2186, 17, false);
#line 48 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
                         Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(2203, 35, true);
            WriteLiteral("\", \"success\");\r\n        </script>\r\n");
            EndContext();
#line 50 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
    }

#line default
#line hidden
            BeginContext(2245, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 51 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
     if (TempData["error"] != null)
    {

#line default
#line hidden
            BeginContext(2289, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(2297, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a323135", async() => {
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
            BeginContext(2367, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2377, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a324324", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2451, 47, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"ERROR\", \"");
            EndContext();
            BeginContext(2499, 17, false);
#line 56 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
                      Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(2516, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 58 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
    }

#line default
#line hidden
            BeginContext(2556, 673, true);
            WriteLiteral(@"    <div class=""block-content block-content-full"">
        <!-- DataTables functionality is initialized with .js-dataTable-full-pagination class in js/pages/be_tables_datatables.min.js which was auto compiled from _es6/pages/be_tables_datatables.js -->
        <table class=""table table-bordered table-striped table-vcenter js-dataTable-full-pagination"">
            <thead>
                <tr>
                    <th>Username</th>
                    <th>Tanggal Gaji</th>
                    <th>Bulan Gaji</th>
                    <th>Total Gaji</th>
                    <th>Nama Tenant</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 72 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
                 foreach (var item in Model)

                {

#line default
#line hidden
            BeginContext(3296, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(3351, 13, false);
#line 76 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
                       Write(item.Username);

#line default
#line hidden
            EndContext();
            BeginContext(3364, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3400, 67, false);
#line 77 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
                       Write(Convert.ToString(string.Format("{0:dd/MM/yyyy}", item.TanggalGaji)));

#line default
#line hidden
            EndContext();
            BeginContext(3467, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3503, 58, false);
#line 78 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
                       Write(Convert.ToString(string.Format("{0:y}", item.TanggalGaji)));

#line default
#line hidden
            EndContext();
            BeginContext(3561, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3597, 11, false);
#line 79 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
                       Write(item.Totaji);

#line default
#line hidden
            EndContext();
            BeginContext(3608, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3644, 22, false);
#line 80 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
                       Write(item.Tenant.TenantName);

#line default
#line hidden
            EndContext();
            BeginContext(3666, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 82 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Penggajian\Listgajiperawat.cshtml"
                }

#line default
#line hidden
            BeginContext(3719, 64, true);
            WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3800, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3806, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a329826", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3890, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3896, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeab79c139242b39e9c28326364a4f71a58008a331082", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3959, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(3964, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CloudDentist.Models.Penggajian>> Html { get; private set; }
    }
}
#pragma warning restore 1591
