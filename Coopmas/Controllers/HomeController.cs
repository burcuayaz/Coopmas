using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Coopmas.Models;
using Microsoft.AspNetCore.Authorization;

namespace Coopmas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Projeler")]

        public IActionResult Projeler()
        {
            return View();
        }
        [Route("TakimOyunculari")]

        public IActionResult TakimOyunculari()
        {
            return View();
        }
        
      //  Ürünler kısmının listelenmesi
       [Route("Urunlerimiz")]
        public IActionResult Urunlerimiz()
        {
           var degerler = c.urunlers.ToList();
           return View(degerler);
       }



        // Ürünlerin detaylarının görüntülendiği sayfa...
       
        public IActionResult UrunDetay(int id)
        {
            var urn = c.urunlers.Find(id);
            return View("UrunDetay", urn);
        }


        //Hizmetler kısmının listelenmesi

        Context c = new Context();
        [Route("Hizmetler")]
        public IActionResult Hizmetlerimiz()
        {
            var degerler = c.hizmetlers.ToList();
            return View(degerler);
        }

        
        //Hizmetlerin detaylarının görüntülendiği sayfa..
        public IActionResult HizmetDetay(int id)
        {
            var hzm = c.hizmetlers.Find(id);

            return View("HizmetDetay", hzm);
        }



        //Talep formu get işlemi...
        [Route("Talepleriniz")]
        [HttpGet]
      
        public IActionResult Talepleriniz()
        {
           
            return View();
        }


        //Talep formu post edildiğinde yapılacaklar...
        [Route("Talepleriniz")]

        [HttpPost]
        public async Task<IActionResult> Talepleriniz([Bind("id,soru1,soru2,soru3,soru4,email,telephone,name")] talep talep)
        {
            if (ModelState.IsValid)
            {
                c.Add(talep);
                await c.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(talep);
        }

       

        [Route("Musteriİliskileri")]
        public IActionResult Musteriİliskileri()
        {
            return View();
        }

        [Route("DanismaMasasi")]
        public IActionResult DanismaMasasi()
        {
            return View();
        }

        //İletişim get kısmı
        [Route("İletisim")]

        [HttpGet]
        public IActionResult İletisim()
        {
            return View();
        }

        //iletişim post edildiğinde yapılanlar..
        [HttpPost]
        [Route("İletisim")]

        public async Task<IActionResult> İletisim([Bind("id,adsoyad,eposta,konu,mesaj")] İletisim iletisim)
        {
            if (ModelState.IsValid)
            {
                c.Add(iletisim);
                await c.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iletisim);
        }



        [Route("Gecmis")]
        public IActionResult Gecmis()
        {
            return View();
        }
        [Route("Gelecek")]
        public IActionResult Gelecek()
        {
            return View();
        }

    }


}
