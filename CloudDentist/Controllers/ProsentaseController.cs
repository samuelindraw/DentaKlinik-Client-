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
    public class ProsentaseController : Controller
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
                HttpResponseMessage response = client.GetAsync("/api/Prosentase").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                {
                    return Redirect("/Home/UnAuthorized");
                }
                
                List<Prosentase> data = JsonConvert.DeserializeObject<List<Prosentase>>(stringData);
                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");
                return View(data);
            }
        }
        public ActionResult Tambah_edit_dataprosentase(int id = 0)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                if (id == 0)
                {
                    return View(id);

                }
                else
                {

                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");
                    HttpResponseMessage response = client.GetAsync("/api/Prosentase/" + id).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    Prosentase data = JsonConvert.DeserializeObject<Prosentase>(stringData);
                    TempData["Pesan"] = "Saved Successfully";
                    return View(data);

                }
            }
        }
        public ActionResult Prosentasetenantid(string tenantID)
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
                    HttpResponseMessage response = client.GetAsync("/api/Prosentase/getbytenantid/" + tenantID).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        return Redirect("/Home/ERROR403");
                    }

                    List<Prosentase> data = JsonConvert.DeserializeObject<List<Prosentase>>(stringData);
                    //Aku lupa ini buat apa ? 
                    //var test = data.FirstOrDefault().Tenant.TenantName;
                    //HttpContext.Session.SetString("datatenant", test);
                    //var datatenant = HttpContext.Session.GetString("datatenant");
                    return View(data);
                }
            }
        }
        [HttpPost]
        public ActionResult Tambah_edit_dataprosentase(Prosentase obj, string returnUrl)
        {
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
                        HttpResponseMessage response = client.PutAsync("/api/Prosentase/" + obj.IdJenisTindakan, contentData).Result;
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

                       return Redirect("/Prosentase/Prosentasetenantid?=" + HttpContext.Session.GetString("TenantID"));
                }
            }

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}