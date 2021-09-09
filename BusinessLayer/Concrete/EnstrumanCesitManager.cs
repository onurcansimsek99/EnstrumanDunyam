using DataAccessLayer.Abstract;
using EnstrumanDunyam.Interfaces;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class EnstrumanCesitManager : IEnstrumanCesitService
    {
        private IEnstrumanCesitDal _enstrumanCesitDal;

        public EnstrumanCesitManager(IEnstrumanCesitDal enstrumanCesitDal)
        {
            _enstrumanCesitDal = enstrumanCesitDal;
        }

        public void Add(EnstrumanCesit enstrumanCesit)
        {
            _enstrumanCesitDal.Add(enstrumanCesit);
        }

        public void Delete(int enstrumanCesitID)
        {
            _enstrumanCesitDal.Delete(enstrumanCesitID);
        }

        public EnstrumanCesit Get(int enstrumanCesitID)
        {
            return _enstrumanCesitDal.Get(enstrumanCesitID);
        }

        public List<EnstrumanCesit> GetAll()
        {
            return _enstrumanCesitDal.GetAll();
        }

        public void Update(EnstrumanCesit enstrumanCesit)
        {
            _enstrumanCesitDal.Update(enstrumanCesit);
        }
    }
}
