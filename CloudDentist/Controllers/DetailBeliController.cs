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
    public class DetailBeliController : Controller
    {
        public IActionResult Index(int id = 0, string Tanggal = null)
        {
            if(Tanggal == null)
            {
                Tanggal = DateTime.Today.ToLongDateString();
            }
            using (HttpClient client = new HttpClient())
            {
                HttpContext.Session.SetString("tanggalbeli", Tanggal);
                if (id == 0)
                {
                    return View();
                }
                else
                {
                    HttpContext.Session.SetString("idBeli", id.ToString());
                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());

                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");


                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    HttpResponseMessage response = client.GetAsync("/api/DetailBeli/sortbeliid/" + id).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        return Redirect("/Home/UnAuthorized");
                    }
                    if (response.StatusCode == HttpStatusCode.NoContent)
                    {
                        return Redirect("/Home/UnAuthorized");
                    }

                    List<DetailBeli> data = JsonConvert.DeserializeObject<List<DetailBeli>>(stringData);
                   
                    //Aku lupa ini buat apa ? 
                    //var test = data.FirstOrDefault().Tenant.TenantName;
                    //HttpContext.Session.SetString("datatenant", test);
                    //var datatenant = HttpContext.Session.GetString("datatenant");
                    return View(data);
                }
            }
        }
        public ActionResult Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                HttpResponseMessage response = client.DeleteAsync("/api/DetailBeli/" + id).Result;
                TempData["alert"] = "delete";
                TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                return Redirect(Request.Headers["Referer"].ToString());

            }
        }
        public ActionResult TambahEditDataDetailBeli(string Id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                if (Id == null)
                {
                    return View(new DetailBeli());

                }
                else
                {
                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");
                    HttpResponseMessage response = client.GetAsync("/api/DetailBeli/" + Id).Result;
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    DetailBeli data = JsonConvert.DeserializeObject<DetailBeli>(stringData);
                    HttpContext.Session.SetInt32("idbarang", data.IdBarang);
                    TempData["Pesan"] = "Saved Successfully";
                    return View(data);

                }
            }
        }

        [HttpPost]
        public ActionResult TambahEditDataDetailBeli(DetailBeli obj)
        {
            obj.IdBeli = Convert.ToInt32(HttpContext.Session.GetString("idBeli"));
            //if (ModelState.IsValid)
            //{
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Helpers.RestAPIAddress.GetUrl());
                    if (obj.DetailBeliId == null)
                    {
                       
                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PostAsync("/api/DetailBeli", contentData).Result;
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
                        if(obj.IdBarang == 0)
                        {
                          obj.IdBarang = (int)HttpContext.Session.GetInt32("idbarang");
                        }
                    
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        //var token = HttpContext.Session.GetString("JWTtoken");
                        obj.IdBeli = Convert.ToInt32(HttpContext.Session.GetString("idBeli"));
                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PutAsync("/api/DetailBeli/" + obj, contentData).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            TempData["success"] = "success";
                            TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                            HttpContext.Session.Remove("idbarang");
                        }
                        else
                        {
                            TempData["error"] = "error";
                            TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                        }
                    }

                }
            

            return Redirect("/DetailBeli/Index/"+ HttpContext.Session.GetString("idBeli"));
        }
    }
}