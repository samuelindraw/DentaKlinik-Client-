using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class DetailPegawaiController : Controller
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
                HttpResponseMessage response = client.GetAsync("/api/DetailPegawai").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return Redirect("/Home/UnAuthorized");
                }

                List<DetailPegawai> data = JsonConvert.DeserializeObject<List<DetailPegawai>>(stringData);
                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");
                return View(data);
            }
        }
        public ActionResult TambahEditDetailPegawai(string Username)
        {
            if (HttpContext.Session.GetString("Loginuser") == Username || HttpContext.Session.GetString("Userrole") == "Admin")
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                    if (Username == null)
                    {
                        return View(new DetailPasien());

                    }
                    else
                    {

                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        HttpResponseMessage response = client.GetAsync("/api/DetailPegawai/" + Username + "/" + HttpContext.Session.GetString("TenantID")).Result;
                        string stringData = response.Content.ReadAsStringAsync().Result;
                        DetailPegawai data = JsonConvert.DeserializeObject<DetailPegawai>(stringData);
                        data.totaji = String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", data.Gaji);
                        foreach (var item in data.Penggajian)
                        {
                            item.Totaji = String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", item.TotalGaji);
                        }
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
        public ActionResult TambahEditDetailPegawai(DetailPegawai obj)
        {

            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                    if (obj.Username == null)
                    {
                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PostAsync("/api/DetailPegawai", contentData).Result;
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
                        HttpResponseMessage response = client.PutAsync("/api/DetailPegawai/?=" + obj.Username, contentData).Result;
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