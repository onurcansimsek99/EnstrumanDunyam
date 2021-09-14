using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class EnstrumanCesitManager : IEnstrumanCesitService
    {
        EfEnstrumanCesitDal _enstrumanCesitDal = new EfEnstrumanCesitDal();

        //public EnstrumanCesitManager()
        //{
        //}

        //public EnstrumanCesitManager(IEnstrumanCesitDal enstrumanCesitDal)
        //{
        //    _enstrumanCesitDal = enstrumanCesitDal;
        //}

        public void Add(EnstrumanCesit enstrumanCesit)
        {
            _enstrumanCesitDal.Add(enstrumanCesit);
        }

        public void Delete(EnstrumanCesit enstrumanCesit)
        {
            _enstrumanCesitDal.Delete(enstrumanCesit);
        }

        public EnstrumanCesit Get(int enstrumanCesitID)
        {
            return _enstrumanCesitDal.Get(i=>i.EnstrumanCesitID==enstrumanCesitID);
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
