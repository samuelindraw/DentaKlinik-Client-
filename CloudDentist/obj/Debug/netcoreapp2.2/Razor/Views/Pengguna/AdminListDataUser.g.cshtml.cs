#pragma checksum "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac93640de9d54c814a304265d9192f419700ed44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pengguna_AdminListDataUser), @"mvc.1.0.view", @"/Views/Pengguna/AdminListDataUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pengguna/AdminListDataUser.cshtml", typeof(AspNetCore.Views_Pengguna_AdminListDataUser))]
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
#line 2 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac93640de9d54c814a304265d9192f419700ed44", @"/Views/Pengguna/AdminListDataUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3efe918c13658fae758fbc71970ee80ead3ba85", @"/Views/_ViewImports.cshtml")]
    public class Views_Pengguna_AdminListDataUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CloudDentist.Models.Pengguna>>
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
#line 3 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
  
    ViewData["Title"] = "AdminListDataUser";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(184, 251, true);
            WriteLiteral("<script type=\"text/javascript\">\r\n        function Delete(Username) {\r\n            alertify.confirm(\'Data Kategori\',\'Apakah anda yakin untuk menghapus data ini ?!\', function (e) {\r\n                if (e) {\r\n                     window.location.href = \'");
            EndContext();
            BeginContext(436, 27, false);
#line 11 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                                        Write(Url.Action("Delete","user"));

#line default
#line hidden
            EndContext();
            BeginContext(463, 255, true);
            WriteLiteral("/\' + Username;\r\n                }\r\n                else {\r\n                     alertify.error(\"You\'ve clicked Cancel\");\r\n                }\r\n            }, null);\r\n\r\n        }\r\n\r\n</script>\r\n<!-- Dynamic Table Full Pagination -->\r\n<h5>Pengaturan Data User ");
            EndContext();
            BeginContext(719, 35, false);
#line 22 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                    Write(Context.Session.GetString("Tenant"));

#line default
#line hidden
            EndContext();
            BeginContext(754, 215, true);
            WriteLiteral("</h5>\r\n<p>Fasilitas ini digunakan untuk menambahkan data Dokter/Perawt baru ke dalam sistem</p>\r\n<div class=\"block\">\r\n    <div class=\"block-header block-header-default\">\r\n        <h3 class=\"block-title\">Data User   ");
            EndContext();
            BeginContext(970, 35, false);
#line 26 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                                       Write(Context.Session.GetString("Tenant"));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 27 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
         if (Context.Session.GetString("userlistrole") == "Dokter")
        {

#line default
#line hidden
            BeginContext(1092, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1106, "\"", 1151, 1);
#line 29 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
WriteAttributeValue("", 1113, Url.Action("RegistrasiDokter","User"), 1113, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1152, 124, true);
            WriteLiteral(" class=\"btn btn-primary bottom-buffer\" id=\"btn-add-user\" style=\"float:right;\"><i class=\"fa fa-plus\"></i> Tambah Dokter</a>\r\n");
            EndContext();
#line 30 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1312, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1326, "\"", 1372, 1);
#line 33 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
WriteAttributeValue("", 1333, Url.Action("RegistrasiPerawat","User"), 1333, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1373, 125, true);
            WriteLiteral(" class=\"btn btn-primary bottom-buffer\" id=\"btn-add-user\" style=\"float:right;\"><i class=\"fa fa-plus\"></i> Tambah Perawat</a>\r\n");
            EndContext();
#line 34 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
        }

#line default
#line hidden
            BeginContext(1509, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 36 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
     if (TempData["alert"] != null)
    {

#line default
#line hidden
            BeginContext(1565, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1573, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac93640de9d54c814a304265d9192f419700ed449555", async() => {
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
            BeginContext(1643, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1653, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac93640de9d54c814a304265d9192f419700ed4410743", async() => {
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
            BeginContext(1727, 54, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Hapus Data!!\", \"");
            EndContext();
            BeginContext(1782, 17, false);
#line 41 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                             Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(1799, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 43 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
    }

#line default
#line hidden
            BeginContext(1839, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 44 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
     if (TempData["success"] != null)
    {

#line default
#line hidden
            BeginContext(1885, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1893, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac93640de9d54c814a304265d9192f419700ed4412928", async() => {
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
            BeginContext(1963, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1973, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac93640de9d54c814a304265d9192f419700ed4414117", async() => {
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
            BeginContext(2047, 50, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"Berhasil\", \"");
            EndContext();
            BeginContext(2098, 17, false);
#line 49 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                         Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(2115, 35, true);
            WriteLiteral("\", \"success\");\r\n        </script>\r\n");
            EndContext();
#line 51 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
    }

#line default
#line hidden
            BeginContext(2157, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 52 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
     if (TempData["error"] != null)
    {

#line default
#line hidden
            BeginContext(2201, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(2209, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac93640de9d54c814a304265d9192f419700ed4416294", async() => {
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
            BeginContext(2279, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2289, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac93640de9d54c814a304265d9192f419700ed4417483", async() => {
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
            BeginContext(2363, 47, true);
            WriteLiteral("\r\n        <script>\r\n            swal(\"ERROR\", \"");
            EndContext();
            BeginContext(2411, 17, false);
#line 57 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                      Write(TempData["Pesan"]);

#line default
#line hidden
            EndContext();
            BeginContext(2428, 33, true);
            WriteLiteral("\", \"error\");\r\n        </script>\r\n");
            EndContext();
#line 59 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
    }

#line default
#line hidden
            BeginContext(2468, 875, true);
            WriteLiteral(@"
    <div class=""block-content block-content-full"">
        <!-- DataTables functionality is initialized with .js-dataTable-full-pagination class in js/pages/be_tables_datatables.min.js which was auto compiled from _es6/pages/be_tables_datatables.js -->
        <table class=""table table-bordered table-striped table-vcenter js-dataTable-full-pagination"">
            <thead>
                <tr>
                    <th>Username</th>
                    <th>Nama</th>
                    <th>Gender</th>
                    <th class=""d-none d-sm-table-cell"">kota</th>
                    <th class=""d-none d-sm-table-cell"">Status</th>
                    <th class=""d-none d-sm-table-cell"">Status</th>
                    <th class=""d-none d-sm-table-cell"" style=""width: 15%;"">Manage Role</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 76 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(3408, 64, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"font-w600\">");
            EndContext();
            BeginContext(3473, 13, false);
#line 79 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                                     Write(item.Username);

#line default
#line hidden
            EndContext();
            BeginContext(3486, 62, true);
            WriteLiteral("</td>\r\n                    <td class=\"d-none d-sm-table-cell\">");
            EndContext();
            BeginContext(3549, 9, false);
#line 80 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                                                  Write(item.Nama);

#line default
#line hidden
            EndContext();
            BeginContext(3558, 62, true);
            WriteLiteral("</td>\r\n                    <td class=\"d-none d-sm-table-cell\">");
            EndContext();
            BeginContext(3621, 11, false);
#line 81 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                                                  Write(item.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(3632, 62, true);
            WriteLiteral("</td>\r\n                    <td class=\"d-none d-sm-table-cell\">");
            EndContext();
            BeginContext(3695, 9, false);
#line 82 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                                                  Write(item.Kota);

#line default
#line hidden
            EndContext();
            BeginContext(3704, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 83 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                     if (@item.IsEnabled == true)
                    {

#line default
#line hidden
            BeginContext(3785, 132, true);
            WriteLiteral("                        <td class=\"text-center\">\r\n                            <a class=\"btn btn-sm btn-secondary m-5 btn-alt-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3917, "\"", 3986, 1);
#line 86 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
WriteAttributeValue("", 3924, Url.Action("Enabled", "User", new {Username = item.Username}), 3924, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3987, 160, true);
            WriteLiteral(">\r\n                                <i class=\"fa fa-toggle-off text-danger\"></i>&nbsp; Disable\r\n                            </a>\r\n                        </td>\r\n");
            EndContext();
#line 90 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(4219, 133, true);
            WriteLiteral("                        <td class=\"text-center\">\r\n                            <a class=\"btn btn-sm btn-secondary m-5 btn-alt-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4352, "\"", 4422, 1);
#line 94 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
WriteAttributeValue("", 4359, Url.Action("Enabled", "User", new {Username = item.Username }), 4359, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4423, 164, true);
            WriteLiteral(">\r\n                                <i class=\"fa fa-toggle-on text-body-bg-dark\"></i>&nbsp; Enable\r\n                            </a>\r\n                        </td>\r\n");
            EndContext();
#line 98 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                    }

#line default
#line hidden
            BeginContext(4610, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 99 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                     if (@item.Status == true)
                    {

#line default
#line hidden
            BeginContext(4681, 71, true);
            WriteLiteral("                        <td class=\"d-none d-sm-table-cell\">Aktif</td>\r\n");
            EndContext();
#line 102 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(4824, 77, true);
            WriteLiteral("                        <td class=\"d-none d-sm-table-cell\">Tidak Aktif</td>\r\n");
            EndContext();
#line 106 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                    }

#line default
#line hidden
            BeginContext(4924, 116, true);
            WriteLiteral("\r\n                    <td class=\"text-center\">\r\n                        <a class=\"btn btn-rounded btn-alt-secondary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5040, "\"", 5120, 1);
#line 109 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
WriteAttributeValue("", 5047, Url.Action("EditDataUser", "Pengguna", new { Username = item.Username }), 5047, 73, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5121, 158, true);
            WriteLiteral(">\r\n                            <i class=\"fa fa-user-circle mr-5\"></i>Profile\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 114 "C:\Users\Samuel\source\repos\CloudDentist\CloudDentist\Views\Pengguna\AdminListDataUser.cshtml"
                }

#line default
#line hidden
            BeginContext(5298, 64, true);
            WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(5362, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac93640de9d54c814a304265d9192f419700ed4426931", async() => {
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
            BeginContext(5432, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5434, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac93640de9d54c814a304265d9192f419700ed4428111", async() => {
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
            BeginContext(5508, 46, true);
            WriteLiteral("\r\n<!-- END Dynamic Table Full Pagination -->\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5571, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5577, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac93640de9d54c814a304265d9192f419700ed4429517", async() => {
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
                BeginContext(5661, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5667, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac93640de9d54c814a304265d9192f419700ed4430773", async() => {
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
                BeginContext(5730, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(5735, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CloudDentist.Models.Pengguna>> Html { get; private set; }
    }
}
#pragma warning restore 1591
