using System;
using System.Collections;
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
    public class TindakanController : Controller
    {
        public IActionResult Index(int Id, string Username)
        {
                return View();
        }
        public ActionResult TambahEditDataTindakan(int id = 0, int idtransaksi = 0 , string tenantID = "")
        {
            
            if (tenantID == HttpContext.Session.GetString("TenantID"))
            {
                using (HttpClient client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://localhost:30512");
                    if (id == 0)
                    {

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
                    Tindakan rawat = new Tindakan();
                    rawat.IdTransaksi = idtransaksi;
                    var alldata = data.Select(pilih => new checkBoxItem()
                    {
                        id = pilih.id,
                        kuadran = pilih.kuadran,
                        gigiPosisi = pilih.gigiPosisi,
                        IsChecked = false
                    }).ToList();
                    alldata = rawat.GigiRawatK2 = data.Where(r => r.kuadran == "2").Select(pilih => new checkBoxItem()
                    {
                        id = pilih.id,
                        kuadran = pilih.kuadran,
                        gigiPosisi = pilih.gigiPosisi,
                        IsChecked = false
                    }).ToList();
                    rawat.GigiRawatK1 = data.Where(r => r.kuadran == "1").OrderByDescending(r => r.gigiPosisi).Select(pilih => new checkBoxItem()
                    {
                        id = pilih.id,
                        kuadran = pilih.kuadran,
                        gigiPosisi = pilih.gigiPosisi,
                        IsChecked = false
                    }).ToList();
                    rawat.GigiRawatK2 = data.Where(r => r.kuadran == "2").Select(pilih => new checkBoxItem()
                    {
                        id = pilih.id,
                        kuadran = pilih.kuadran,
                        gigiPosisi = pilih.gigiPosisi,
                        IsChecked = false
                    }).ToList();
                    rawat.GigiRawatK4 = data.Where(r => r.kuadran == "4").OrderByDescending(r => r.gigiPosisi).Select(pilih => new checkBoxItem()
                    {
                        id = pilih.id,
                        kuadran = pilih.kuadran,
                        gigiPosisi = pilih.gigiPosisi,
                        IsChecked = false
                    }).ToList();
                    rawat.GigiRawatK3 = data.Where(r => r.kuadran == "3").Select(pilih => new checkBoxItem()
                    {
                        id = pilih.id,
                        kuadran = pilih.kuadran,
                        gigiPosisi = pilih.gigiPosisi,
                        IsChecked = false
                    }).ToList();
                    rawat.GigiRawatKI = data.Where(r => r.kuadran == "I").OrderByDescending(r => r.gigiPosisi).Select(pilih => new checkBoxItem()
                    {
                        id = pilih.id,
                        kuadran = pilih.kuadran,
                        gigiPosisi = pilih.gigiPosisi,
                        IsChecked = false
                     }).ToList();
                     rawat.GigiRawatKII = data.Where(r => r.kuadran == "II").Select(pilih => new checkBoxItem()
                     {
                         id = pilih.id,
                         kuadran = pilih.kuadran,
                         gigiPosisi = pilih.gigiPosisi,
                         IsChecked = false
                     }).ToList();
                        rawat.GigiRawatKIV = data.Where(r => r.kuadran == "IV").OrderByDescending(r => r.gigiPosisi).Select(pilih => new checkBoxItem()
                        {
                            id = pilih.id,
                            kuadran = pilih.kuadran,
                            gigiPosisi = pilih.gigiPosisi,
                            IsChecked = false
                        }).ToList();
                        rawat.GigiRawatKIII = data.Where(r => r.kuadran == "III").Select(pilih => new checkBoxItem()
                        {
                            id = pilih.id,
                            kuadran = pilih.kuadran,
                            gigiPosisi = pilih.gigiPosisi,
                            IsChecked = false
                        }).ToList();
                        return View(rawat);

                    }
                    else
                    {

                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");
                        HttpResponseMessage response = client.GetAsync("/api/Tindakan/" + id).Result;
                        string stringData = response.Content.ReadAsStringAsync().Result;
                        Tindakan data = JsonConvert.DeserializeObject<Tindakan>(stringData);
                        //Tindakan rawat = new Tindakan();
                        //rawat.IdTransaksi = id; 
                        var alldata = data.GigiRawat.Select(pilih => new checkBoxItem()
                        {
                            id = pilih.id,
                            kuadran = pilih.kuadran,
                            gigiPosisi = pilih.gigiPosisi,
                            IsChecked = false
                        }).ToList();
                        data.GigiRawatK1 = data.GigiRawat.Where(r => r.kuadran == "1").OrderByDescending(r => r.gigiPosisi).Select(pilih => new checkBoxItem()
                        {
                            id = pilih.id,
                            kuadran = pilih.kuadran,
                            gigiPosisi = pilih.gigiPosisi,
                            IsChecked = pilih.IsChecked
                        }).ToList();
                        data.GigiRawatK2 = data.GigiRawat.Where(r => r.kuadran == "2").OrderBy(r => r.gigiPosisi).Select(pilih => new checkBoxItem()
                        {
                            id = pilih.id,
                            kuadran = pilih.kuadran,
                            gigiPosisi = pilih.gigiPosisi,
                            IsChecked =  pilih.IsChecked
                        }).ToList();
                        data.GigiRawatK4 = data.GigiRawat.Where(r => r.kuadran == "4").OrderByDescending(r => r.gigiPosisi).Select(pilih => new checkBoxItem()
                        {
                            id = pilih.id,
                            kuadran = pilih.kuadran,
                            gigiPosisi = pilih.gigiPosisi,
                            IsChecked = pilih.IsChecked
                        }).ToList();
                        data.GigiRawatK3 = data.GigiRawat.Where(r => r.kuadran == "3").OrderBy(r=>r.gigiPosisi).Select(pilih => new checkBoxItem()
                        {
                            id = pilih.id,
                            kuadran = pilih.kuadran,
                            gigiPosisi = pilih.gigiPosisi,
                            IsChecked = pilih.IsChecked
                        }).ToList();
                        data.GigiRawatKI = data.GigiRawat.Where(r => r.kuadran == "I").OrderByDescending(r => r.gigiPosisi).Select(pilih => new checkBoxItem()
                        {
                            id = pilih.id,
                            kuadran = pilih.kuadran,
                            gigiPosisi = pilih.gigiPosisi,
                            IsChecked = pilih.IsChecked
                        }).ToList();
                        data.GigiRawatKII = data.GigiRawat.Where(r => r.kuadran == "II").OrderByDescending(r => r.gigiPosisi).Select(pilih => new checkBoxItem()
                        {
                            id = pilih.id,
                            kuadran = pilih.kuadran,
                            gigiPosisi = pilih.gigiPosisi,
                            IsChecked = pilih.IsChecked
                        }).ToList();
                        data.GigiRawatKIV = data.GigiRawat.Where(r => r.kuadran == "IV").OrderByDescending(r => r.gigiPosisi).Select(pilih => new checkBoxItem()
                        {
                            id = pilih.id,
                            kuadran = pilih.kuadran,
                            gigiPosisi = pilih.gigiPosisi,
                            IsChecked = false
                        }).ToList();
                        data.GigiRawatKIII = data.GigiRawat.Where(r => r.kuadran == "III").Select(pilih => new checkBoxItem()
                        {
                            id = pilih.id,
                            kuadran = pilih.kuadran,
                            gigiPosisi = pilih.gigiPosisi,
                            IsChecked = false
                        }).ToList();
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
        public ActionResult TambahEditDataTindakan(Tindakan obj, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:30512");
                    if (obj.IdTindakan == 0)
                    {
                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer",
                        HttpContext.Session.GetString("JWTtoken"));
                        var token = HttpContext.Session.GetString("JWTtoken");

                        string stringData = JsonConvert.SerializeObject(obj);
                        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = client.PostAsync("/api/Tindakan", contentData).Result;
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
                            var tenant = HttpContext.Session.GetString("TenantID");
                            //return Redirect("/Barang/barangtenantid?tenantID=" + tenant);
                            return Redirect("/Tindakan/TambahEditDataTindakan?IdTransaksi=" + obj.IdTransaksi +"&tenantID=" + obj.TenantID);
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
                        HttpResponseMessage response = client.PutAsync("/api/Tindakan/" + obj.IdTindakan, contentData).Result;
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
                            return Redirect("/Tindakan/TambahEditDataTindakan?Id=" + obj.IdTindakan + "&tenantID=" + obj.TenantID);
                        //ambahEditDataTindakan ? IdTransaksi = 1213 & tenantID = edbb2900 - 67c9 - 4c17 - 8c35 - cd8e583cb93e





                    }

                }
            }

            return Redirect(Request.Headers["Referer"].ToString());
        }

    }
}