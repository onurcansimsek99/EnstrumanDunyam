using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnstrumanDunyam.Interfaces
{
    public interface IKulaniciService
    {
        List<Kullanici> GetAll();
        Kullanici Get(int kullaniciID);
        void Add(Kullanici kullanici);
        void Delete(int kullaniciID);
        void Update(Kullanici kullanici);
    }
}
