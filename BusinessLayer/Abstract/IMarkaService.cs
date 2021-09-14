using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IMarkaService
    {
        List<Marka> GetAll();
        Marka Get(int markaID);
        void Add(Marka marka);
        void Delete(Marka marka);
        void Update(Marka marka);
    }
}
