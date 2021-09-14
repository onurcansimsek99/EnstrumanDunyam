using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class EnstrumanManager : IEnstrumanService
    {
        EfEnstrumanDal _enstrumanDal = new EfEnstrumanDal();

        //public EnstrumanManager()
        //{
        //}

        //public EnstrumanManager(IEnstrumanDal enstrumanDal)
        //{
        //    _enstrumanDal = enstrumanDal;
        //}

        public void Add(Enstruman enstruman)
        {
            _enstrumanDal.Add(enstruman);
        }

        public void Delete(Enstruman enstruman)
        {
            _enstrumanDal.Delete(enstruman);
        }

        public Enstruman Get(int enstrumanID)
        {
            return _enstrumanDal.Get(i=>i.EnstrumanID==enstrumanID);
        }

        public List<Enstruman> GetAll()
        {
            return _enstrumanDal.GetAll();
        }

        public void Update(Enstruman enstruman)
        {
            _enstrumanDal.Update(enstruman);
        }
    }
}
