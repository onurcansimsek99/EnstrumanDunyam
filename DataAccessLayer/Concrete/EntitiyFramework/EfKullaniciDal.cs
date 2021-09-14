using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete.EntitiyFramework
{
    public class EfKullaniciDal : GenericRepository<Kullanici>, IKullaniciDal
    {
        //    private Context _context = new Context();
        //    public void Add(Kullanici kullanici)
        //    {
        //        _context.Kullanicis.Add(kullanici);
        //        _context.SaveChanges();
        //    }

        //    public void Delete(int kullaniciID)
        //    {
        //        _context.Kullanicis.Remove(_context.Kullanicis.FirstOrDefault(p => p.KullaniciID == kullaniciID));
        //        _context.SaveChanges();
        //    }

        //    public Kullanici Get(int kullaniciID)
        //    {
        //        return _context.Kullanicis.FirstOrDefault(p => p.KullaniciID == kullaniciID);
        //    }

        //    public List<Kullanici> GetAll()
        //    {
        //        return _context.Kullanicis.ToList();
        //    }

        //    public void Update(Kullanici kullanici)
        //    {
        //        Kullanici kullaniciToUpdate = _context.Kullanicis.FirstOrDefault(p => p.KullaniciID == kullanici.KullaniciID);

        //        kullaniciToUpdate.KullaniciAdi = kullanici.KullaniciAdi;
        //        kullaniciToUpdate.KullaniciSifre = kullanici.KullaniciSifre;

        //        _context.SaveChanges();

        //    }
        //}
    }
}
