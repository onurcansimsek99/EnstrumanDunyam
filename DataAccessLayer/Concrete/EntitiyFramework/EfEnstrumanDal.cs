using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete.EntitiyFramework
{
    public class EfEnstrumanDal : IEnstrumanDal
    {
        private Context _context = new Context();
        public void Add(Enstruman enstruman)
        {
            _context.Enstrumans.Add(enstruman);
            _context.SaveChanges();
        }

        public void Delete(int enstrumanID)
        {
            _context.Enstrumans.Remove(_context.Enstrumans.FirstOrDefault(p => p.EnstrumanID == enstrumanID));
            _context.SaveChanges();
        }

        public Enstruman Get(int enstrumanID)
        {
            return _context.Enstrumans.FirstOrDefault(p => p.EnstrumanID == enstrumanID);
        }

        public List<Enstruman> GetAll()
        {
            return _context.Enstrumans.ToList();
        }

        public void Update(Enstruman enstruman)
        {
            Enstruman enstrumanToUpdate = _context.Enstrumans.FirstOrDefault(p => p.EnstrumanID == enstruman.EnstrumanID);

            enstrumanToUpdate.EnstrumanID = enstruman.EnstrumanID;
            enstrumanToUpdate.EnstrumanAdi = enstruman.EnstrumanAdi;
            enstrumanToUpdate.EnstrumanGorsel = enstruman.EnstrumanGorsel;
            enstrumanToUpdate.EnstrumanTuru = enstruman.EnstrumanTuru;
            enstrumanToUpdate.EnstrumanMarkasi = enstruman.EnstrumanMarkasi;
            enstrumanToUpdate.EnstrumanFiyati = enstruman.EnstrumanFiyati;
            enstrumanToUpdate.OneCikanMi = enstruman.OneCikanMi;
            enstrumanToUpdate.EnstrumanYuklemeTarihi = enstruman.EnstrumanYuklemeTarihi;

            enstrumanToUpdate.EnstrumanCesitID = enstruman.EnstrumanCesitID;
            enstrumanToUpdate.MarkaID = enstruman.MarkaID;
            _context.SaveChanges();
        }
    }
}
