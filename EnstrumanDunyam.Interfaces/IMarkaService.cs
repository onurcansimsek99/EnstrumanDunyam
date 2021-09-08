using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnstrumanDunyam.Interfaces
{
    public interface IMarkaService
    {
        List<Marka> GetAll();
        Marka Get();
        void Add(Marka marka);
        void Delete(int markaID);
        void Update(Marka marka);
    }
}
