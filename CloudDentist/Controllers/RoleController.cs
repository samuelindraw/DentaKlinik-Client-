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
    public class RoleController : Controller
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
                HttpResponseMessage response = client.GetAsync("/api/UserRole").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return Redirect("/Home/UnAuthorized");
                }

                List<UserRole> data = JsonConvert.DeserializeObject<List<UserRole>>(stringData);


                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");
                
                return View(data);
            }
        }
        public ActionResult TambaheditData(string RoleName)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                if (RoleName == null)
                {
                    return View(new UserRole());

                }
                else
                {
                    HttpResponseMessage response = client.GetAsync("/api/UserRole/" + RoleName).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    UserRole data = JsonConvert.DeserializeObject<UserRole>(stringData);
                    //List<UserRole> data = JsonConvert.DeserializeObject<List<UserRole>>(stringData);
                    return View(data);
                }
            }
        }
        public ActionResult Delete(string id, string roleID)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                HttpResponseMessage response = client.DeleteAsync("/api/UserRole/" + id).Result;
                TempData["alert"] = "delete";
                TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                return RedirectToAction("Index");

            }
        }
        public ActionResult DeleteUserRole(UserModel role)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                HttpResponseMessage response = client.DeleteAsync("/api/UserRole/removeuserrole" + role).Result;
                TempData["Message"] = response.Content.ReadAsStringAsync().Result;
                TempData["Pesan"] = "User Role Deleted Successfully";
                return RedirectToAction("Index");

            }
        }
        [HttpPost]
        public ActionResult TambahEditData(UserRole obj)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                if (obj.roleID == null)
                {
                    string stringData = JsonConvert.SerializeObject(obj);
                    var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync("/api/UserRole", contentData).Result;

                    if(response.IsSuccessStatusCode)
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
                    string stringData = JsonConvert.SerializeObject(obj);
                    var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PutAsync("/api/UserRole", contentData).Result;
                    ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                    TempData["success"] = "success";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;

                }
                return RedirectToAction("Index");
            }
        }
    }
}