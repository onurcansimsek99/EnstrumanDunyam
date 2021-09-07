using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete.EntitiyFramework
{
    public class EfMarkaDal : IMarkaDal
    {
        private Context _context = new Context();
        public void Add(Marka marka)
        {
            _context.Markas.Add(marka);
            _context.SaveChanges();
        }

        public void Delete(int markaID)
        {
            _context.Markas.Remove(_context.Markas.FirstOrDefault(p => p.MarkaID == markaID));
            _context.SaveChanges();
        }

        public Marka Get(int markaID)
        {
            return _context.Markas.FirstOrDefault(p => p.MarkaID == markaID);
        }

        public List<Marka> GetAll()
        {
            return _context.Markas.ToList();
        }

        public void Update(Marka marka)
        {
            Marka markaToUpdate = _context.Markas.FirstOrDefault(p => p.MarkaID == marka.MarkaID);

            markaToUpdate.MarkaAdi = marka.MarkaAdi;
            
        }
    }
}
