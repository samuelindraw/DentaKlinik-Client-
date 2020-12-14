using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CloudDentist.Models;
using CloudDentist.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CloudDentist.Controllers
{
    public class UserController : Controller
    {
        public ActionResult RegistrasiDokter()
        {

            return View(new UserModel());
        }
        [HttpPost]
        public ActionResult RegistrasiDokter(UserModel user)
        {
            using (HttpClient client = new HttpClient())
            {
                user.TenantID = HttpContext.Session.GetString("TenantID");
                user.TanggalJoin = DateTime.Today;
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                string stringData = JsonConvert.SerializeObject(user);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("/api/User/register", contentData).Result;
                ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode == true)
                {
                    TempData["success"] = "success";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    //HttpContext.Session.SetString("usernamepengguna", user.Username);
                    return Redirect("/Pengguna/AdminListDataUser?tenantID=" + user.rolename);
                }
                else
                {
                    TempData["error"] = "error";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    return View();
                }
            }
        }
        public ActionResult RegistrasiPerawat()
        {
            return View(new UserModel());
        }
        [HttpPost]
        public ActionResult RegistrasiPerawat(UserModel user)
        {
            using (HttpClient client = new HttpClient())
            {
                user.TenantID = HttpContext.Session.GetString("TenantID");
                user.TanggalJoin = DateTime.Today;
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                string stringData = JsonConvert.SerializeObject(user);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("/api/User/register", contentData).Result;
                ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode == true)
                {
                    TempData["success"] = "success";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    //HttpContext.Session.SetString("usernamepengguna", user.Username);
                    return Redirect("/Pengguna/AdminListDataUser?tenantID=" + user.rolename);
                }
                else
                {
                    TempData["error"] = "error";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    return View();
                }
            }
        }
        public ActionResult RegisterPasien()
        {
            return View(new UserModel());
        }
        [HttpPost]
        public ActionResult RegisterPasien(UserModel user)
        {

            using (HttpClient client = new HttpClient())
            {
                user.TenantID = HttpContext.Session.GetString("TenantID");
                user.rolename = "Pasien";
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                string stringData = JsonConvert.SerializeObject(user);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("/api/User/RegisterPasien", contentData).Result;
                ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode == true)
                {
                    TempData["success"] = "success";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    //HttpContext.Session.SetString("usernamepengguna", user.Username);
                    return Redirect("/Pengguna/listDataPasien?Username=" + user.Username);
                   
                }
                else
                {
                    TempData["error"] = "error";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    return View();
                }
            }
        }
        public ActionResult listuser()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512/");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));

                var token = HttpContext.Session.GetString("JWTtoken");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("/api/User/getall").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                List<UserModel> data = JsonConvert.DeserializeObject<List<UserModel>>(stringData);
                return View(data);
            }
        }
        public ActionResult Delete(string Id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                HttpResponseMessage response = client.DeleteAsync("/api/user/" + Id).Result;
                TempData["alert"] = "delete";
                TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                return RedirectToAction("listuser");

            }
        }
        //KHUSUS UNTUK PROFILE KITAS // harap edit namanya
        public ActionResult TambahEditDataUser()
        {

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                HttpResponseMessage response = client.GetAsync("/api/Pengguna/getpenggunausername/" + HttpContext.Session.GetString("Loginuser")).Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                Pengguna data = JsonConvert.DeserializeObject<Pengguna>(stringData);
                return View(data);
            }
        }
        [HttpPost]
        public ActionResult TambahEditDataUser(Pengguna obj)
        {
            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                        obj.rolename = HttpContext.Session.GetString("Userrole");
                        obj.Username = HttpContext.Session.GetString("Loginuser");
                        client.BaseAddress = new Uri("http://localhost:30512");
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        //var token = HttpContext.Session.GetString("JWTtoken");
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PutAsync("/api/Pengguna/" + obj.Username, contentData).Result;
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

        public ActionResult Enabled(string Username, enable obj)
        {
            obj.Username = Username;
            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:30512");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    //var token = HttpContext.Session.GetString("JWTtoken");
                    string stringData = JsonConvert.SerializeObject(obj);
                    var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PutAsync("/api/User/Enable/" + Username, contentData).Result;
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
        public ActionResult ForgetPassword(EmailForget EmailForget)
        {
            if(EmailForget.Email == null)
            {
                return View(new EmailForget());
            }
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                string stringData = JsonConvert.SerializeObject(EmailForget);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("/api/User/ForgetPassword", contentData).Result;
                ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode == true)
                {
                    TempData["success"] = "success";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    //HttpContext.Session.SetString("usernamepengguna", user.Username);
                    return Redirect("/Login");
                }
                else
                {
                    TempData["error"] = "error";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    return View();
                }
            }
        }
        [HttpGet]
        public ActionResult ResetPassword(string Email, string token)
        {
            ResetPasswordViewModel model = new ResetPasswordViewModel();
            model.Token = token;
            model.Email = Email;
            return View(model);
        }
        [HttpPost]
        public ActionResult ResetPassword(ResetPasswordViewModel model)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                string stringData = JsonConvert.SerializeObject(model);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("/api/User/ResetPassword", contentData).Result;
                ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode == true)
                {
                    TempData["success"] = "success";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    //HttpContext.Session.SetString("usernamepengguna", user.Username);
                    return Redirect("/Login");
                }
                else
                {
                    TempData["error"] = "error";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    return View();
                }
            }
        }
        [HttpGet]
        public ActionResult ChangePassword(string Username)
        {
            ChangePasswordViewModel model = new ChangePasswordViewModel();
            model.Username = Username;
            return View(model);
        }
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordViewModel model)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                string stringData = JsonConvert.SerializeObject(model);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("/api/User/ChangePassword", contentData).Result;
                ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode == true)
                {
                    TempData["success"] = "success";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    //HttpContext.Session.SetString("usernamepengguna", user.Username);
                    return View();
                }
                else
                {
                    TempData["error"] = "error";
                    TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                    return View();
                }
            }
        }
    }
}