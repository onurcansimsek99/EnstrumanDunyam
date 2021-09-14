using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IKullaniciService
    {
        List<Kullanici> GetAll();
        Kullanici Get(int kullaniciID);
        void Add(Kullanici kullanici);
        void Delete(Kullanici kullanici);
        void Update(Kullanici kullanici);
    }
}
