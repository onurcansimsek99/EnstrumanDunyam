using DataAccessLayer.Abstract;
using EnstrumanDunyam.Interfaces;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class MarkaManager : IMarkaService
    {
        private IMarkaDal _markaDal;

        public MarkaManager(IMarkaDal markaDal)
        {
            _markaDal = markaDal;
        }

        public void Add(Marka marka)
        {
            _markaDal.Add(marka);
        }

        public void Delete(int markaID)
        {
            _markaDal.Delete(markaID);
        }

        public Marka Get(int markaID)
        {
            return _markaDal.Get(markaID);
        }

        public List<Marka> GetAll()
        {
            return _markaDal.GetAll();
        }

        public void Update(Marka marka)
        {
            _markaDal.Update(marka);
        }
    }
}
