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
    public class JualController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult TambahEditDataJual(int id = 0,  int idtransaksi = 0, string TenantID = "")
        {
            var test = HttpContext.Session.GetString("TenantID");
            if (TenantID == test)
            {
                using (HttpClient client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://localhost:30512");
                    if (idtransaksi != 0)
                    {
                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        HttpResponseMessage response = client.GetAsync("/api/Transaksi/" + idtransaksi).Result;
                        string stringData = response.Content.ReadAsStringAsync().Result;
                        Transaksi data = JsonConvert.DeserializeObject<Transaksi>(stringData);
                        var totalharga = 0;
                        foreach (var item in data.Jual)
                        {
                            totalharga = + item.Harga;
                            data.TotalJual = data.TotalJual + totalharga;
                        }

                        var totaltindakan = 0;
                        foreach (var item in data.Tindakan)
                        {
                            totaltindakan = +item.biaya;
                            data.TotalBayarTindakan = data.TotalBayarTindakan + totaltindakan;
                        }
                        data.TotalBayar = data.TotalBayarTindakan + data.TotalJual;
                        TempData["Pesan"] = "Saved Successfully";
                        return View(data);

                    }
                    else
                    {

                        return View(new Jual());

                    }
                }
            }
            else
            {
                return Redirect("/Home/ERROR403");
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
                HttpResponseMessage response = client.DeleteAsync("/api/jual/" + id).Result;
                if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                {
                    return Redirect("/Home/ERROR403");
                }
                TempData["alert"] = "delete";
                TempData["Pesan"] = response.Content.ReadAsStringAsync().Result;
                //reload to same apge
                return Redirect("/Jual/TambahEditDataJual?itransaksi="+id+"&tenantid=" + HttpContext.Session.GetString("TenantID"));
               

            }
        }
    }
}