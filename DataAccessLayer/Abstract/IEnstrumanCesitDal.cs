using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IEnstrumanCesitDal
    {
        List<EnstrumanCesit> GetAll();
        EnstrumanCesit Get(int enstrumanCesitID);
        void Add(EnstrumanCesit enstrumanCesit);
        void Delete(int enstrumanCesitID);
        void Update(EnstrumanCesit enstrumanCesit);
        

    }
}
