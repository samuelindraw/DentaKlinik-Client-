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
    public class TransaksiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult list_transaksi_pasien(string Id, string tenantID)
        {
            if (HttpContext.Session.GetString("TenantID") == tenantID)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:30512");
                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");
                    //hanler ketika unathorized by role ? 

                    HttpResponseMessage response = client.GetAsync("/api/Pengguna/getidpasien/" + Id + "/" + tenantID).Result;
                    if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                    {
                        return Redirect("/Home/UnAuthorized");
                    }
                    if(response.StatusCode == HttpStatusCode.InternalServerError)
                    {
                        return Redirect("/Home/ERROR403");
                    }
                    HttpContext.Session.SetString("pasien_Periksa", Id);
                    string stringData = response.Content.ReadAsStringAsync().Result;
                    Pengguna data = JsonConvert.DeserializeObject<Pengguna>(stringData);
                    TempData["Pesan"] = "Saved Successfully";
                    return View(data);

                }
            }
            return Redirect("/Home/UnAuthorized");
        }
        public ActionResult detailTransaksi(int idtransaksi, string tenantID)
        {
            if (HttpContext.Session.GetString("TenantID") == tenantID)
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
                        string joinedStrings = "";
                        foreach (var item in data.Tindakan)
                        {
                            if (item.Posisi != null)
                            {
                                string[] test = new string[item.GigiRawat.Count];
                                for (int i = 0; i < item.GigiRawat.Count; i++)
                                {
                                    test[i] = (item.GigiRawat[i].kuadran + ":" + item.GigiRawat[i].gigiPosisi);
                                }
                                joinedStrings = string.Join(",", test);
                                
                            }
                            data.posisigigi = joinedStrings;
                        }
                        
                        var totalharga = 0;
                        foreach (var item in data.Jual)
                        {
                            totalharga = +item.Harga;
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
            return Redirect("/Home/UnAuthorized");
        }
        public ActionResult Tambah_edit_Transaksi(int Id, string Username, string tenantID)
        {
            if (HttpContext.Session.GetString("TenantID") == tenantID)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:30512");
                    client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer",
                    HttpContext.Session.GetString("JWTtoken"));
                    var token = HttpContext.Session.GetString("JWTtoken");
                    if (Id == 0)
                    {
                        Transaksi baru = new Transaksi();
                        baru.IdPasien = Username;
                        return View(baru);
                    }
                    else
                    {
                        HttpResponseMessage response = client.GetAsync("/api/Transaksi/" + Id).Result;
                        string stringData = response.Content.ReadAsStringAsync().Result;
                        Transaksi data = JsonConvert.DeserializeObject<Transaksi>(stringData);
                        //List<Transaksi> data = JsonConvert.DeserializeObject<List<Transaksi>>(stringData);
                        return View(data);
                    }
                }

            }
            return Redirect("/Home/UnAuthorized");

        }

        public ActionResult Transaksi_Selesai(Tindakan obj,int idtransaksi)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");

                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                obj.IdTransaksi = idtransaksi;
                string stringData = JsonConvert.SerializeObject(obj);
                //ganti link
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync("/api/Tindakan/Transaksi_Selesai", contentData).Result;
                if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                {
                    return Redirect("/Home/UnAuthorized");
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
                if (HttpContext.Session.GetString("Userrole") == "Admin")
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return Redirect("/Home/Index");
                }
                //var data1 = response.Content.ReadAsStringAsync().Result.ToList().ToString();
            }
                   
        }
        public ActionResult Transaksi_Batal(int idtransaksi)
        {
            if(idtransaksi == 0)
            {
                TempData["error"] = "success";
                TempData["Pesan"] = "Transaksi Telah di Batalkan";
                return Redirect("/Home/Index");
            }
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:30512");
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer",
                HttpContext.Session.GetString("JWTtoken"));
                var token = HttpContext.Session.GetString("JWTtoken");
                HttpResponseMessage response = client.DeleteAsync("/api/Transaksi/BatalTransaksi/" + idtransaksi).Result;
                if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.Forbidden)
                {
                    return Redirect("/Home/UnAuthorized");
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
                return Redirect("/Home/Index");
                //HARUS NYA REDIRECT KE PAGE PASIEN 
                //var data1 = response.Content.ReadAsStringAsync().Result.ToList().ToString();
            }

        }

        public ActionResult CetakInvoice(int idtransaksi, string tenantID)
        {
            if (HttpContext.Session.GetString("TenantID") == tenantID)
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
                        string joinedStrings = "";
                        foreach (var item in data.Tindakan)
                        {
                            if (item.Posisi != null)
                            {
                                string[] test = new string[item.GigiRawat.Count];
                                for (int i = 0; i < item.GigiRawat.Count; i++)
                                {
                                    test[i] = (item.GigiRawat[i].kuadran + ":" + item.GigiRawat[i].gigiPosisi);
                                }
                                joinedStrings = string.Join(",", test);

                            }
                            data.posisigigi = joinedStrings;
                        }

                        var totalharga = 0;
                        foreach (var item in data.Jual)
                        {
                            totalharga = +item.Harga;
                            data.TotalJual = data.TotalJual + totalharga;
                        }
                        var totaltindakan = 0;
                        foreach (var item in data.Tindakan)
                        {
                            totaltindakan = +item.biaya;
                            data.TotalBayarTindakan = data.TotalBayarTindakan + totaltindakan;
                        }
                        data.TotalBayar = (data.TotalBayarTindakan + data.TotalJual);

                        data.TotalBayar = String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", data.TotalBayar);
                        data.TotalJual = String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", data.TotalJual);
                        data.TotalBayarTindakan = String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", data.TotalBayarTindakan);
                        TempData["Pesan"] = "Saved Successfully";
                        return View(data);

                    }
                    else
                    {

                        return View(new Jual());

                    }
                }
            }
            return Redirect("/Home/UnAuthorized");
        }
    }
}