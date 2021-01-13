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
    public class DetailPasienController : Controller
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
                HttpResponseMessage response = client.GetAsync("/api/DetailPasien").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return Redirect("/Home/UnAuthorized");
                }

                List<DetailPasien> data = JsonConvert.DeserializeObject<List<DetailPasien>>(stringData);
                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");
                return View(data);
            }
        }
        public ActionResult TambahEditDetailPasien(string IdPasien, string Username)
        {
            if (HttpContext.Session.GetString("Userrole") == "Admin"||HttpContext.Session.GetString("Userrole") == "Dokter" || HttpContext.Session.GetString("Userrole") == "Perawat" || HttpContext.Session.GetString("Userrole") == "Pasien")
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                    if (IdPasien == null)
                    {
                        return View(new DetailPasien());

                    }
                    else
                    {

                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        HttpResponseMessage response = client.GetAsync("/api/DetailPasien/" + IdPasien + "/" + HttpContext.Session.GetString("TenantID")).Result;
                        string stringData = response.Content.ReadAsStringAsync().Result;
                        DetailPasien data = JsonConvert.DeserializeObject<DetailPasien>(stringData);
                        TempData["Pesan"] = "Saved Successfully";
                        return View(data);
                      
                    }
                }
            }
            else
            {
                return Redirect("/Home/ERROR403");
            }
        }

        [HttpPost]
        public ActionResult TambahEditDetailPasien(DetailPasien obj)
        {

            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                    if (obj.IdPasien == null)
                    {
                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PostAsync("/api/DetailPasien", contentData).Result;
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
                        HttpResponseMessage response = client.PutAsync("/api/DetailPasien/?=" + obj.IdPasien, contentData).Result;
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

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}