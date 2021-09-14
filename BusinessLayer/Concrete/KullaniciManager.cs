using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        EfKullaniciDal _kullaniciDal = new EfKullaniciDal();

        //public KullaniciManager()
        //{
        //}

        //public KullaniciManager(IKullaniciDal kullaniciDal)
        //{
        //    _kullaniciDal = kullaniciDal;
        //}

        public void Add(Kullanici kullanici)
        {
            _kullaniciDal.Add(kullanici);
        }

        public void Delete(Kullanici kullanici)
        {
            _kullaniciDal.Delete(kullanici);
        }

       
        public Kullanici Get(int kullaniciID)
        {
            return _kullaniciDal.Get(i=>i.KullaniciID==kullaniciID);
        }

        public List<Kullanici> GetAll()
        {
            return _kullaniciDal.GetAll();
        }

        public void Update(Kullanici kullanici)
        {
            _kullaniciDal.Update(kullanici);
        }
    }
}
