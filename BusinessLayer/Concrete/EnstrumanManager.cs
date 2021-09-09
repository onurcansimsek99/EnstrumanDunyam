using DataAccessLayer.Abstract;
using EnstrumanDunyam.Interfaces;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class EnstrumanManager : IEnstrumanService
    {
        private IEnstrumanDal _enstrumanDal;

        public EnstrumanManager(IEnstrumanDal enstrumanDal)
        {
            _enstrumanDal = enstrumanDal;
        }

        public void Add(Enstruman enstruman)
        {
            _enstrumanDal.Add(enstruman);
        }

        public void Delete(int enstrumanID)
        {
            _enstrumanDal.Delete(enstrumanID);
        }

        public Enstruman Get(int enstrumanID)
        {
            return _enstrumanDal.Get(enstrumanID);
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
