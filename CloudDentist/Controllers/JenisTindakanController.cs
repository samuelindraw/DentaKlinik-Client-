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
    public class JenisTindakanController : Controller
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
                HttpResponseMessage response = client.GetAsync("/api/JenisTindakan").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return Redirect("/Home/UnAuthorized");
                }

                List<JenisTindakan> data = JsonConvert.DeserializeObject<List<JenisTindakan>>(stringData);
                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");
                return View(data);
            }
        }
        public ActionResult TambahEditDataJenisTindakan(int id = 0)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                if (id == 0)
                {
                    return View(new JenisTindakan());

                }
                else
                {

                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");
                    HttpResponseMessage response = client.GetAsync("/api/JenisTindakan/" + id).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    JenisTindakan data = JsonConvert.DeserializeObject<JenisTindakan>(stringData);
                    
                    TempData["Pesan"] = "Saved Successfully";
                    return View(data);

                }
            }
        }

        [HttpPost]
        public ActionResult TambahEditDataJenisTindakan(JenisTindakan obj)
        {

            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                    if (obj.IdJenisTindakan == 0)
                    {
                        
                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                            HttpResponseMessage response = client.PostAsync("/api/JenisTindakan", contentData).Result;
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
                        HttpResponseMessage response = client.PutAsync("/api/JenisTindakan/" + obj.IdJenisTindakan, contentData).Result;
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
            var tenant = HttpContext.Session.GetString("TenantID");
            return Redirect("/JenisTindakan/JenisTindakantenantid?tenantID=" + tenant);

        }
        public ActionResult Delete(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                HttpResponseMessage response = client.DeleteAsync("/api/JenisTindakan/" + id).Result;
                TempData["alert"] = "delete";
                TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                var tenant = HttpContext.Session.GetString("TenantID");
                return Redirect("/JenisTindakan/JenisTindakantenantid?tenantID=" + tenant);

            }
        }
        public ActionResult JenisTindakantenantid(string tenantID)
        {
            using (HttpClient client = new HttpClient())
            {
                if (tenantID != HttpContext.Session.GetString("TenantID"))
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


                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    HttpResponseMessage response = client.GetAsync("/api/JenisTindakan/getkatjenistindakanbytenantid/" + tenantID).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        return Redirect("/Home/ERROR403");
                    }

                    List<JenisTindakan> data = JsonConvert.DeserializeObject<List<JenisTindakan>>(stringData);
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