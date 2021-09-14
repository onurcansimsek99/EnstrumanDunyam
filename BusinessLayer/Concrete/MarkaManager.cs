using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class MarkaManager : IMarkaService
    {
        EfMarkaDal _markaDal = new EfMarkaDal();

        //public MarkaManager()
        //{
        //}

        //public MarkaManager(IMarkaDal markaDal)
        //{
        //    _markaDal = markaDal;
        //}

        public void Add(Marka marka)
        {
            _markaDal.Add(marka);
        }

        public void Delete(Marka marka)
        {
            _markaDal.Delete(marka);
        }

        public Marka Get(int markaID)
        {
            return _markaDal.Get(i=>i.MarkaID==markaID);
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
