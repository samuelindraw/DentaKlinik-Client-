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
    public class BarangController : Controller
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
                HttpResponseMessage response = client.GetAsync("/api/Barang").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                {
                    return Redirect("/Home/UnAuthorized");
                }

                List<Barang> data = JsonConvert.DeserializeObject<List<Barang>>(stringData);
                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");
                return View(data);
            }
        }
        public ActionResult TambahEditDataBarang(int id = 0)
        {

                using (HttpClient client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://localhost:30512");
                    if (id == 0)
                    {
                        return View(new Barang());

                    }
                    else
                    {

                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        HttpResponseMessage response = client.GetAsync("/api/Barang/" + id).Result;
                        string stringData = response.Content.ReadAsStringAsync().Result;
                        Barang data = JsonConvert.DeserializeObject<Barang>(stringData);
                        TempData["Pesan"] = "Saved Successfully";
                        return View(data);

                    }
                }

        }

        [HttpPost]
        public ActionResult TambahEditDataBarang(Barang obj, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:30512");
                    if (obj.IdBarang == 0)
                    {
                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PostAsync("/api/Barang", contentData).Result;
                        if (response.StatusCode == HttpStatusCode.Forbidden)
                        {
                            return Redirect("/Home/UnAuthorized");
                        }
                        if(response.StatusCode == HttpStatusCode.BadRequest)
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
                        else
                        {
                            TempData["error"] = "error";
                            TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                        }

                        var tenant = HttpContext.Session.GetString("TenantID");
                        return Redirect("/Barang/barangtenantid?tenantID=" + tenant);


                        //var data1 = response.Content.ReadAsStringAsync().Result.ToList().ToString();
                    }
                    else
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        //var token = HttpContext.Session.GetString("JWTtoken");
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PutAsync("/api/Barang/" + obj.IdBarang, contentData).Result;
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

                        
                            var tenant = HttpContext.Session.GetString("TenantID");
                            return Redirect("/Barang/barangtenantid?tenantID=" + tenant);
                        
                    }

                }
            }

            return Redirect("/Barang/barangtenantid?tenantID=" + HttpContext.Session.GetString("TenantID"));
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
                HttpResponseMessage response = client.DeleteAsync("/api/Barang/" + id).Result;
                if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                {
                    return Redirect("/Home/ERROR403");
                }
                TempData["alert"] = "delete";
                TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                var tenant = HttpContext.Session.GetString("TenantID");
                return Redirect("/Barang/barangtenantid?tenantID=" + tenant);

            }
        }
        public ActionResult barangtenantid(string tenantID)
        {
            using (HttpClient client = new HttpClient())
            {
                if (tenantID != HttpContext.Session.GetString("TenantID"))
                {
                    return Redirect("/Home/UnAuthorized");
                }
                else
                {
                    client.BaseAddress = new Uri("http://localhost:30512");

                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");


                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    HttpResponseMessage response = client.GetAsync("/api/Barang/getbarangtenantid/" + tenantID).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        return Redirect("/Home/ERROR403");
                    }

                    List<Barang> data = JsonConvert.DeserializeObject<List<Barang>>(stringData);
                    //Aku lupa ini buat apa ? 
                    //var test = data.FirstOrDefault().Tenant.TenantName;
                    //HttpContext.Session.SetString("datatenant", test);
                    //var datatenant = HttpContext.Session.GetString("datatenant");
                    return View(data);
                }
            }
        }
    }
}