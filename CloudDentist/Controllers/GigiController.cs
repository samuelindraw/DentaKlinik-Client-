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
    public class GigiController : Controller
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
                HttpResponseMessage response = client.GetAsync("/api/posisigigi").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return Redirect("/Home/UnAuthorized");
                }

                List<posisiGigi> data = JsonConvert.DeserializeObject<List<posisiGigi>>(stringData);
                Tindakanviewmodel rawat = new Tindakanviewmodel();
                rawat.GigiRawat = data.Select(pilih => new checkBoxItem()
                {
                    id = pilih.id,
                    kuadran = pilih.kuadran,
                    gigiPosisi = pilih.gigiPosisi,
                    IsChecked = false

                }).ToList();
                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");
                return View(rawat);
            }
        }
        public ActionResult Tindakanviewmodel()
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
                HttpResponseMessage response = client.GetAsync("/api/posisigigi").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return Redirect("/Home/UnAuthorized");
                }

                List<posisiGigi> data = JsonConvert.DeserializeObject<List<posisiGigi>>(stringData);
                Tindakanviewmodel rawat = new Tindakanviewmodel();
                rawat.GigiRawat = data.Select(pilih => new checkBoxItem()
                {
                    id = pilih.id,
                    kuadran = pilih.kuadran,
                    gigiPosisi = pilih.gigiPosisi,
                    IsChecked = false

                }).ToList();
                //Aku lupa ini buat apa ? 
                //var test = data.FirstOrDefault().Tenant.TenantName;
                //HttpContext.Session.SetString("datatenant", test);
                //var datatenant = HttpContext.Session.GetString("datatenant");
                //return Redirect("/Home/UnAuthorized");
               // return RedirectToAction("Transaksi","Transaksi_tindakan_partial", rawat);
                return RedirectToAction("Transaksi_tindakan_partial", "Transaksi", new { area = "Tindakan" });
            }
        }
    }
}