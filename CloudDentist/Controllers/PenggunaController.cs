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
    public class PenggunaController : Controller
    {
        public IActionResult DaftarPengguna()
        {
            return View();
        }
        public ActionResult datapasien()
        {
            using (HttpClient client = new HttpClient())
            {
                var tenantID = HttpContext.Session.GetString("TenantID");
                if (tenantID == null)
                {
                    return View();
                }
                else
                {
                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());

                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");
                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    HttpResponseMessage response = client.GetAsync("/api/Pengguna/getlistpasien/" + tenantID + "/" + "Pasien").Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        return Redirect("/Home/ERROR403");
                    }
                    List<Pengguna> data = JsonConvert.DeserializeObject<List<Pengguna>>(stringData);
                    return View(data);
                }
            }
        }
        public ActionResult listDataPasien()
        {
            using (HttpClient client = new HttpClient())
            {
               
                if (HttpContext.Session.GetString("Userrole") == "Admin" || HttpContext.Session.GetString("Userrole") == "Dokter" || HttpContext.Session.GetString("Userrole") == "Perawat")
                {

                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");


                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    HttpResponseMessage response = client.GetAsync("/api/Pengguna/getlistpasien/" + HttpContext.Session.GetString("TenantID") + "/"+ "Pasien").Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        return Redirect("/Home/ERROR403");
                    }

                    List<Pengguna> data = JsonConvert.DeserializeObject<List<Pengguna>>(stringData);
                    return View(data);
                }
                else
                {
                    return Redirect("/Home/UnAuthorized");
                }
            }

        }
        public ActionResult EditDataPasien(string IdPasien)
        {
            using (HttpClient client = new HttpClient())
            {

                if (HttpContext.Session.GetString("Userrole") == "Admin" || HttpContext.Session.GetString("Userrole") == "Dokter" || HttpContext.Session.GetString("Userrole") == "Perawat")
                {

                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());

                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");


                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    HttpResponseMessage response = client.GetAsync("/api/Pengguna/getidPasien/" + IdPasien +"/"+ HttpContext.Session.GetString("TenantID")).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        return Redirect("/Home/ERROR403");
                    }

                    Pengguna data = JsonConvert.DeserializeObject<Pengguna>(stringData);
                    //Aku lupa ini buat apa ? 
                    //var test = data.FirstOrDefault().Tenant.TenantName;
                    //HttpContext.Session.SetString("datatenant", test);
                    //var datatenant = HttpContext.Session.GetString("datatenant");
                    return View(data);
                }
                else
                {
                    return Redirect("/Home/UnAuthorized");
                }

            }

        }
        [HttpPost]
        public ActionResult EditDataPasien(Pengguna obj)
        {
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
        public ActionResult AdminListDataUser(string rolename)
        {
            using (HttpClient client = new HttpClient())
            {
                 
                var tenantID = HttpContext.Session.GetString("TenantID");
                if (tenantID == null)
                {
                    return Redirect("/Home/UnAuthorized");
                }
                else
                {
                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");

                    if (rolename == null)
                    {

                        rolename = HttpContext.Session.GetString("userlistrole");
                    }
                    else
                    {
                        HttpContext.Session.SetString("userlistrole", rolename);
                    }
                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    HttpResponseMessage response = client.GetAsync("/api/Pengguna/getuserbyrole/" + tenantID + "/" + rolename).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        return Redirect("/Home/ERROR403");
                    }
                    
                    List<Pengguna> data = JsonConvert.DeserializeObject<List<Pengguna>>(stringData);
                   
                    return View(data);
                }
            }

        }

        //untuk edit data user di DOKTER / PERAWAT
        public ActionResult EditDataUser(string Username)
        {
            using (HttpClient client = new HttpClient())
            {

                if (HttpContext.Session.GetString("Userrole") == "Admin" || HttpContext.Session.GetString("Userrole") == "Dokter")
                {

                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");
                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    HttpResponseMessage response = client.GetAsync("/api/Pengguna/getpenggunausername/" + Username ).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        return Redirect("/Home/ERROR403");
                    }

                    Pengguna data = JsonConvert.DeserializeObject<Pengguna>(stringData);
                    return View(data);
                }
                else
                {
                    return Redirect("/Home/UnAuthorized");
                }
            }
        }
        [HttpPost]
        public ActionResult EditDataUser(Pengguna obj)
        {
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
       
    }
}