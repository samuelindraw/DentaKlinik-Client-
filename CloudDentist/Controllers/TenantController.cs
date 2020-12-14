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
    public class TenantController : Controller
    {
        public IActionResult Index()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");

                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("/api/Tenant").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return Redirect("/Home/UnAuthorized");
                }

                List<Tenant> data = JsonConvert.DeserializeObject<List<Tenant>>(stringData);


                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");

                return View(data);
            }
        }
        public ActionResult TambahEditDataTenant(string Id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                if (Id == null)
                {
                    return View(new Tenant());

                }
                else
                {
                    HttpResponseMessage response = client.GetAsync("/api/Tenant/" + Id).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    Tenant data = JsonConvert.DeserializeObject<Tenant>(stringData);
                    //List<UserRole> data = JsonConvert.DeserializeObject<List<UserRole>>(stringData);
                    return View(data);
                }
            }
        }
        public ActionResult Delete(string id, string TenantID)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                HttpResponseMessage response = client.DeleteAsync("/api/Tenant/" + id).Result;
                TempData["alert"] = "delete";
                TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                return RedirectToAction("Index");

            }
        }
        [HttpPost]
        public ActionResult TambahEditDataTenant(Tenant obj)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                if (obj.TenantID == null)
                {
                    string stringData = JsonConvert.SerializeObject(obj);
                    var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync("/api/Tenant", contentData).Result;

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
                else
                {
                    client.BaseAddress = new Uri("http://localhost:30512");
                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    string stringData = JsonConvert.SerializeObject(obj);
                    var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PutAsync("/api/Tenant",contentData).Result;
                    ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                    TempData["success"] = "success";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;

                }
                return RedirectToAction("Index");
            }
        }
    }
}