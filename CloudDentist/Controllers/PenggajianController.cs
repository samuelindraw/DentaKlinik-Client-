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
    public class PenggajianController : Controller
    {
        public IActionResult Penggajian(string TenantID)
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
                HttpResponseMessage response = client.GetAsync("/api/penggajian/GetDataGajibyroletenant/" + HttpContext.Session.GetString("TenantID") + "/" + "Dokter").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                {
                    return Redirect("/Home/UnAuthorized");
                }

                List<Penggajian> data = JsonConvert.DeserializeObject<List<Penggajian>>(stringData);
                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");
                return View(data);
            }
        }
        public ActionResult GajiDokter(int id = 0)
        {

            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://localhost:30512");
                if (id == 0)
                {
                    return View(new Penggajian());

                }
                else
                {

                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");
                    HttpResponseMessage response = client.GetAsync("/api/Penggajian/" + id).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    Penggajian data = JsonConvert.DeserializeObject<Penggajian>(stringData);
                    TempData["Pesan"] = "Saved Successfully";
                    return View(data);

                }
            }

        }
        public IActionResult Listgajiperawat()
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
                HttpResponseMessage response = client.GetAsync("/api/penggajian/GetDataGajibyroletenant/" + HttpContext.Session.GetString("TenantID") + "/" + "Perawat").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                {
                    return Redirect("/Home/UnAuthorized");
                }

                List<Penggajian> data = JsonConvert.DeserializeObject<List<Penggajian>>(stringData);
                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");
                return View(data);
            }
        }
        public ActionResult GajiPerawat()
        {
            return View(new Penggajian());
        }
        [HttpPost]
        public ActionResult GajiPerawat(Penggajian penggajian)
        {

            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://localhost:30512");

                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");
                    string stringData = JsonConvert.SerializeObject(penggajian);
                    var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync("/api/Penggajian/GajiPerawat", contentData).Result;
                    if (response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        return Redirect("/Home/UnAuthorized");
                    }
                    if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        TempData["error"] = "error";
                        TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                        return Redirect("/Barang/barangtenantid?tenantID=" + HttpContext.Session.GetString("TenantID"));
                    }
                    if (response.IsSuccessStatusCode)
                    {

                        TempData["success"] = "success";
                        TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;


                    } 
            }
            return Redirect("/Home");

        }
        public ActionResult DetailPenggajian(int idGaji)
        {

            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://localhost:30512");

                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");
                    HttpResponseMessage response = client.GetAsync("/api/Penggajian/" + idGaji).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    Penggajian data = JsonConvert.DeserializeObject<Penggajian>(stringData);
                    TempData["Pesan"] = "Saved Successfully";
                    return View(data);
            }

        }
        public ActionResult Delete(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                HttpResponseMessage response = client.DeleteAsync("/api/Penggajian/" + id).Result;
                if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                {
                    return Redirect("/Home/ERROR403");
                }
                TempData["alert"] = "delete";
                TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                var tenant = HttpContext.Session.GetString("TenantID");
                return Redirect("/Penggajian/Penggajian");

            }
        }

        [HttpPost]
        public ActionResult GajiDokter(Penggajian obj)
        {
            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:30512");
                    if (obj.IdGaji == 0)
                    {
                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PostAsync("/api/Penggajian", contentData).Result;
                        if (response.StatusCode == HttpStatusCode.Forbidden)
                        {
                            return Redirect("/Home/UnAuthorized");
                        }
                        if (response.StatusCode == HttpStatusCode.BadRequest)
                        {
                            TempData["error"] = "error";
                            TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                            return Redirect("/Penggajian/Penggajian");
                        }
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

                        return Redirect("/Penggajian/Penggajian");
                    }
                    else
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        //var token = HttpContext.Session.GetString("JWTtoken");
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PutAsync("/api/Penggajian/" + obj.IdGaji, contentData).Result;
                        if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                        {
                            return Redirect("/Home/ERROR403");
                        }
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


                        return Redirect("/Penggajian/Penggajian");

                    }

                }
            }

            return Redirect("/Penggajian/Penggajian");
        }
    }

}