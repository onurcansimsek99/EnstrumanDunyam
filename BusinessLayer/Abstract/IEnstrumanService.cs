using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IEnstrumanService
    {
        List<Enstruman> GetAll();
        Enstruman Get(int enstrumanID);
        void Add(Enstruman enstruman);
        void Delete(Enstruman enstruman);
        void Update(Enstruman enstruman);
    }
}
