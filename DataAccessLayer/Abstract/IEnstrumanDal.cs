using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IEnstrumanDal
    {
        List<Enstruman> GetAll();
        Enstruman Get(int enstrumanID);
        void Add(Enstruman enstruman);
        void Delete(int enstrumanID);
        void Update(Enstruman enstruman);

    }
}
