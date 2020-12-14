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
    public class KatBarangController : Controller
    {
        // GET: KatBarang
        public ActionResult Index(KatBarang kat_barang)
        {
            using (HttpClient client = new HttpClient())
            {
                //client.BaseAddress = new Uri("http://localhost:30512");   

                //client.DefaultRequestHeaders.Authorization =
                //new AuthenticationHeaderValue("Bearer",
                //HttpContext.Session.GetString("JWTtoken"));
                //var token = HttpContext.Session.GetString("JWTtoken");


                //MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                //client.DefaultRequestHeaders.Accept.Add(contentType);
                //HttpResponseMessage response = client.GetAsync("/api/KatBarang").Result;
                //if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                //{
                //    return Redirect("/Home/ERROR403");
                //}
                //string stringData = response.Content.ReadAsStringAsync().Result;

                //List<KatBarang> data = JsonConvert.DeserializeObject<List<KatBarang>>(stringData);
                return View();
            }
        }
        public ActionResult TambaheditData(int id = 0)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                if (id == 0)
                {
                    return View(new KatBarang());

                }
                else
                {
                    
                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");
                    HttpResponseMessage response = client.GetAsync("/api/KatBarang/" + id).Result;
                    if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        return Redirect("/Home/ERROR403");
                    }
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    KatBarang data = JsonConvert.DeserializeObject<KatBarang>(stringData);

                    TempData["Pesan"] = "Saved Successfully";
                    return View(data);

                }
            }
        }

        [HttpPost]
        public ActionResult TambahEditData(KatBarang obj)
        {
            if (obj.TenantID == null)
            {
                obj.Tenant = null;
                obj.TenantID = HttpContext.Session.GetString("TenantID");
            }
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:30512");
                    if (obj.IdKategori == 0)
                    {
                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PostAsync("/api/KatBarang", contentData).Result;
                        if (response.StatusCode == HttpStatusCode.Forbidden)
                        {
                            return Redirect("/Home/ERROR403");
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
                        else
                        {
                            TempData["error"] = "error";
                            TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                        }

                        return Redirect("/KatBarang/KatBarangbytenant?tenantID=" + HttpContext.Session.GetString("TenantID"));

                        //var data1 = response.Content.ReadAsStringAsync().Result.ToList().ToString();
                    }
                    else
                    {
                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PutAsync("/api/KatBarang/" + obj.IdKategori, contentData).Result;
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
                         return Redirect("/KatBarang/KatBarangbytenant?tenantID=" + HttpContext.Session.GetString("TenantID"));

                }                
            }
         
        }
        public ActionResult Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                HttpResponseMessage response = client.DeleteAsync("/api/KatBarang/" + id).Result;
                TempData["alert"] = "delete";
                TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                return Redirect("/KatBarang/KatBarangbytenant?tenantID=" + HttpContext.Session.GetString("TenantID"));

            }
        }
        public ActionResult KatBarangbytenant(string tenantID)
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
                    HttpResponseMessage response = client.GetAsync("/api/KatBarang/getkatbarangtenantid/" + tenantID).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        return Redirect("/Home/ERROR403");
                    }
                    List<KatBarang> data = JsonConvert.DeserializeObject<List<KatBarang>>(stringData);
                    return View(data);
                }
            }
        }
    }
}

