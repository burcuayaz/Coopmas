using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Coopmas.Models;

namespace Coopmas.Controllers
{
    public class AdminController : Controller
    {

        Context c = new Context();
        [Route("UrunListele")]
        public IActionResult UrunListele()
        {
            var degerler = c.urunlers.ToList();
            return View(degerler);

        }


        [HttpGet]
        public IActionResult UrunEkle()
        {
            return View();
        }

    

        [HttpPost]
        public IActionResult UrunEkle(Urunler u)
        {
            c.urunlers.Add(u);
            c.SaveChanges();
            return RedirectToAction("UrunListele");
           
        }

        public IActionResult UrunSil(int id)
        {
            var urn = c.urunlers.Find(id);
            c.urunlers.Remove(urn);
            c.SaveChanges();
            return RedirectToAction("UrunListele");

        }




        public IActionResult UrunGetir(int id)
        {
            var urn = c.urunlers.Find(id);
            return View("UrunGetir",urn);
        }


        public IActionResult UrunGuncelle(Urunler u)
        {
            var urn = c.urunlers.Find(u.ID);
            urn.AD = u.AD;
            urn.Ozellik = u.Ozellik;
            urn.Dokumantasyon = u.Dokumantasyon;
            urn.Fiyat = u.Fiyat;
            urn.Satisİletisim = u.Satisİletisim;
            c.SaveChanges();
            return RedirectToAction("UrunListele");
        }

     


        







        [Route("HizmetListele")]

        public IActionResult HizmetListele()
        {
            var degerler = c.hizmetlers.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult HizmetEkle()
        {
            return View();
        }


        [HttpPost]
        public IActionResult HizmetEkle(Hizmetler h)
        {
            c.hizmetlers.Add(h);
            c.SaveChanges();
            return RedirectToAction("HizmetListele");

        }

        public IActionResult HizmetSil(int id)
        {
            var hzm = c.hizmetlers.Find(id);
            c.hizmetlers.Remove(hzm);
            c.SaveChanges();
            return RedirectToAction("HizmetListele");

        }
        public IActionResult HizmetGetir(int id)
        {
            var hzm = c.hizmetlers.Find(id);
            return View("HizmetGetir", hzm);
        }
        public IActionResult HizmetGuncelle(Hizmetler h)
        {
            var hzm = c.hizmetlers.Find(h.id);
            hzm.HizmetAdi = h.HizmetAdi;
            hzm.Ozellik = h.Ozellik;
            hzm.Dokumantasyon = h.Dokumantasyon;
            hzm.Fiyat = h.Fiyat;
            hzm.Satisİletisim = h.Satisİletisim;
            c.SaveChanges();
            return RedirectToAction("HizmetListele");
        }















        [Route("TalepGoruntule")]

        public IActionResult TalepGoruntule()
        {
            var degerler = c.taleps.ToList();
            return View(degerler);
        }
        public IActionResult TalepSil(int id)
        {
            var tlp = c.taleps.Find(id);
            c.taleps.Remove(tlp);
            c.SaveChanges();
            return RedirectToAction("TalepGoruntule");

        }






        [Route("MesajGoruntule")]

        public IActionResult MesajGoruntule()
        {
            var degerler = c.İletisims.ToList();
            return View(degerler);
        }
        public IActionResult MesajSil(int id)
        {
            var msj = c.İletisims.Find(id);
            c.İletisims.Remove(msj);
            c.SaveChanges();
            return RedirectToAction("MesajGoruntule");

        }




    }
}
