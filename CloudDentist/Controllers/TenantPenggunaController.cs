using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CloudDentist.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CloudDentist.Controllers
{
    public class TenantPenggunaController : Controller
    {
        public IActionResult Index()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());

                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");


                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("/api/TenantPengguna").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return Redirect("/Home/UnAuthorized");
                }

                List<TenantPengguna> data = JsonConvert.DeserializeObject<List<TenantPengguna>>(stringData);
                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");
                return View(data);
            }
        }
        public ActionResult TambahEditDataTenantPengguna(string TenantPenggunaID, string Username)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                if (TenantPenggunaID == null)
                {
                    return View(new TenantPengguna());

                }
                else
                {

                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");
                    HttpResponseMessage response = client.GetAsync("/api/TenantPengguna/").Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    TenantPengguna data = JsonConvert.DeserializeObject<TenantPengguna>(stringData);
                    TempData["Pesan"] = "Saved Successfully";
                    return View(data);

                }
            }
        }
        public ActionResult EnabledTenant(string Username,string tenantID, enable obj)
        {
            obj.Username = Username;
            obj.TenantID = tenantID;
            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    //var token = HttpContext.Session.GetString("JWTtoken");
                    string stringData = JsonConvert.SerializeObject(obj);
                    var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                    //HttpResponseMessage response = client.PutAsync("/api/User/Enable/" + Username "/" + tenantID, contentData).Result;
                    HttpResponseMessage response = client.PutAsync("/api/tenantpengguna/EnableTenant/" + Username + "/" + tenantID, contentData).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        TempData["success"] = "success";
                        TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    }
                    else
                    {
                        TempData["error"] = "error";
                        TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    }


                }
            }

            return Redirect(Request.Headers["Referer"].ToString());
        }

        [HttpPost]
        public ActionResult TambahEditDataTenantPengguna(TenantPengguna obj, string Username)
        {
            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                    if (obj.TenantPenggunaID == null)
                    {
                        obj.Username = Username; 
                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PostAsync("/api/TenantPengguna", contentData).Result;
                        if (response.IsSuccessStatusCode)
                        {

                            TempData["success"] = "success";
                            TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                        }
                        else
                        {
                            TempData["error"] = "error";
                            TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                        }
                        //var data1 = response.Content.ReadAsStringAsync().Result.ToList().ToString();
                    }
                    else
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        //var token = HttpContext.Session.GetString("JWTtoken");
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PutAsync("/api/TenantPengguna/" + obj.TenantPenggunaID, contentData).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            TempData["success"] = "success";
                            TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                        }
                        else
                        {
                            TempData["error"] = "error";
                            TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                        }
                    }

                }
            }

            return Redirect("Pengguna/EditDataUser?Username=" + obj.Username);
        }
        public ActionResult Delete(string id)
        {            
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                HttpResponseMessage response = client.DeleteAsync("/api/TenantPengguna/" + id).Result;
                TempData["alert"] = "delete";
                TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                return Redirect(Request.Headers["Referer"].ToString());

            }
        }
    }
}