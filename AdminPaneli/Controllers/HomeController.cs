using AdminPaneli.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using DataAccessLayer.Concrete.EntitiyFramework;
using DataAccessLayer.Concrete;


namespace AdminPaneli.Controllers
{
    public class HomeController : Controller
    {

        Context c = new Context();                                       //...

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Urunler()
        {
            var degerler = c.Enstrumans.ToList();
            return View(degerler);

        }

        [HttpGet]
        public IActionResult YeniUrun()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniUrun(Enstruman p)
        {
            c.Enstrumans.Add(p);
            c.SaveChanges();
            return RedirectToAction("Urunler");
        }

        public IActionResult UrunSil(int id)
        {
            var urun = c.Enstrumans.Find(id);
            c.Enstrumans.Remove(urun);
            c.SaveChanges();
            return RedirectToAction("Urunler");
        }

        public IActionResult UrunGetir(int id)
        {
            var urun = c.Enstrumans.Find(id);
            return View("UrunGetir", urun);
        }

        public IActionResult UrunGuncelle(Enstruman e)
        {
            var urun = c.Enstrumans.Find(e.EnstrumanID);
            urun.EnstrumanAdi = e.EnstrumanAdi;
            urun.EnstrumanGorsel = e.EnstrumanGorsel;
            urun.EnstrumanTuru = e.EnstrumanTuru;
            urun.EnstrumanMarkasi = e.EnstrumanMarkasi;
            urun.EnstrumanFiyati = e.EnstrumanFiyati;
            urun.OneCikanMi = e.OneCikanMi;
            urun.EnstrumanYuklemeTarihi = e.EnstrumanYuklemeTarihi;
            urun.MarkaID = e.MarkaID;
            urun.EnstrumanCesitID = e.EnstrumanCesitID;
            c.SaveChanges();
            return RedirectToAction("Urunler");
        }



        public IActionResult UrunCesitleri()
        {
            return View();
        }

        public IActionResult Markalar()
        {
            return View();
        }

        public IActionResult Blog()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniBlog()
        {
            return View();                  //sayfa yüklenince sadece sayfayı döndür
        }

        [HttpPost]
        public IActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Blog");
        }

        public IActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Blog");
        }

        public IActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }

        public IActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.BlogID);
            blg.BlogBaslik = b.BlogBaslik;
            blg.BlogIcerik = b.BlogIcerik;
            blg.BlogYazar = b.BlogYazar;
            blg.BlogYayinlanmaTarihi = b.BlogYayinlanmaTarihi;
            c.SaveChanges();
            return RedirectToAction("Blog");
            
        }

        public IActionResult Slider()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
