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
using System.IO;
using Microsoft.AspNetCore.Http;
using BusinessLayer.Concrete;

namespace AdminPaneli.Controllers
{
    public class HomeController : Controller
    {

        Context c = new Context();

        ImageManager _imageManager = new ImageManager();

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
            var degerler = c.EnstrumanCesits.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniUrunCesidi()
        {

            return View();
        }

        [HttpPost]
        public IActionResult YeniUrunCesidi(EnstrumanCesit ec)
        {
            c.EnstrumanCesits.Add(ec);
            c.SaveChanges();
            return RedirectToAction("UrunCesitleri");
        }

        public IActionResult UrunCesitSil(int id)
        {
            var urunCesit = c.EnstrumanCesits.Find(id);
            c.EnstrumanCesits.Remove(urunCesit);
            c.SaveChanges();
            return RedirectToAction("UrunCesitleri");
        }

        public IActionResult UrunCesitGetir(int id)
        {
            var ur = c.EnstrumanCesits.Find(id);
            return View("UrunCesitGetir", ur);
        }

        public IActionResult UrunCesitGuncelle(EnstrumanCesit ec)
        {
            var cesitGuncelle = c.EnstrumanCesits.Find(ec.EnstrumanCesitID);
            cesitGuncelle.EnstrumanCesitAdi = ec.EnstrumanCesitAdi;
            cesitGuncelle.EnstrumanCesitAciklamasi = ec.EnstrumanCesitAciklamasi;
            c.SaveChanges();
            return RedirectToAction("UrunCesitleri");
        }

        public IActionResult Markalar()
        {
            var degerler = c.Markas.ToList();
            return View(degerler);

        }

        [HttpGet]
        public IActionResult YeniMarka()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniMarka(Marka m)
        {
            c.Markas.Add(m);
            c.SaveChanges();
            return RedirectToAction("Markalar");
        }

        public IActionResult MarkaSil(int id)
        {
            var deger = c.Markas.Find(id);
            c.Markas.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Markalar");
        }

        public IActionResult MarkaGetir(int id)
        {
            var mrk = c.Markas.Find(id);
            return View("MarkaGetir", mrk);
        }

        public IActionResult MarkaGuncelle(Marka m)
        {
            var mg = c.Markas.Find(m.MarkaID);
            mg.MarkaAdi = m.MarkaAdi;
            c.SaveChanges();
            return RedirectToAction("Markalar");
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
            blg.BlogGorsel = b.BlogGorsel;
            blg.BlogBaslik = b.BlogBaslik;
            blg.BlogIcerik = b.BlogIcerik;
            blg.BlogYazar = b.BlogYazar;
            blg.BlogYayinlanmaTarihi = b.BlogYayinlanmaTarihi;
            c.SaveChanges();
            return RedirectToAction("Blog");

        }

        public IActionResult Slider()
        {
            var degerler = c.Sliders.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniSlider()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniSlider(Slider s)
        {
            c.Sliders.Add(s);
            c.SaveChanges();
            return RedirectToAction("Slider");
        }

        public IActionResult SliderSil(int id)
        {
            var s = c.Sliders.Find(id);
            c.Sliders.Remove(s);
            c.SaveChanges();
            return RedirectToAction("Slider");
        }

        public IActionResult SliderGetir(int id)
        {
            var sl = c.Sliders.Find(id);
            return View("SliderGetir", sl);
        }

        public IActionResult SliderGuncelle(Slider s)
        {
            var sld = c.Sliders.Find(s.SliderID);
            sld.SliderBaslik = s.SliderBaslik;
            sld.SliderAciklama = s.SliderAciklama;
            sld.SliderGorsel = s.SliderGorsel;
            c.SaveChanges();
            return RedirectToAction("Slider");
        }


        [HttpPost("addImage")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] Image image, [FromForm(Name = ("imageID"))] int id)
        {
           _imageManager.Add(file, image, id);

            return Ok();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
