using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnstrumanDunyam.Interfaces
{
    public interface IEnstrumanService
    {
        List<Enstruman> GetAll();
        Enstruman Get();
        void Add(Enstruman enstruman);
        void Delete(int enstrumanID);
        void Update(Enstruman enstruman);
    }
}
