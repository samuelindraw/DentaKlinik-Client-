using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CloudDentist.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CloudDentist.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index(UserModel user)
        {
            return View();
        }
        public IActionResult Login(AuthenticateModel user)
        {
           if(user.Username == null)
            {
                return Redirect("/Login");
            }
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                string stringData = JsonConvert.SerializeObject(user);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("/api/User/Login", contentData).Result;
                string data = response.Content.ReadAsStringAsync().Result;
                //HttpContext.Session.SetString("LoginRoles", Userloginroles);


                if (response.IsSuccessStatusCode)
                {
                    var DataUser = JsonConvert.DeserializeObject<UserModel>(data);
                    if (DataUser.rolename != null)
                    {
                        //convert from json response to Object Model
                        // take value from object model
                        HttpContext.Session.SetString("JWTtoken", DataUser.Token);
                        HttpContext.Session.SetString("Loginuser", DataUser.Username);
                        HttpContext.Session.SetString("Userrole", DataUser.rolename);
                        HttpContext.Session.SetString("TenantID", DataUser.TenantID);
                        HttpContext.Session.SetString("Tenant", DataUser.TenantName);
                        TempData["success"] = "success";
                        TempData["Pesan"] = "Login Berhasil !";
                        return RedirectToAction("Index", "Home");
                    }

                    else
                    {
                        TempData["error"] = "error";
                        TempData["Pesan"] = "Username atau password anda salah !";
                        return RedirectToAction("Index");
                    }
                   
                }

                else
                {
                    TempData["error"] = "error";
                    TempData["Pesan"] = data;
                    return RedirectToAction("Index");
                }
            }
        }
        public IActionResult Logout(UserModel user)
        {
            HttpContext.Session.Clear();
            TempData["error"] = "error";
            TempData["Pesan"] = "Telah Berhasil Logout";
            return Redirect("~/Login");
        }
    }
}