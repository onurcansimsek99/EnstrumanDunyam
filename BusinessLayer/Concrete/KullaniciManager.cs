using DataAccessLayer.Abstract;
using EnstrumanDunyam.Interfaces;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class KullaniciManager : IKulaniciService
    {
        private IKullaniciDal _kullaniciDal;

        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public void Add(Kullanici kullanici)
        {
            _kullaniciDal.Add(kullanici);
        }

        public void Delete(int kullaniciID)
        {
            _kullaniciDal.Delete(kullaniciID);
        }

        public Kullanici Get(int kullaniciID)
        {
            return _kullaniciDal.Get(kullaniciID);
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
