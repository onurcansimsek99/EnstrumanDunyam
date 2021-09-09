using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnstrumanDunyam.Interfaces
{
    public interface IEnstrumanCesitService
    {
        List<EnstrumanCesit> GetAll();
        EnstrumanCesit Get(int enstrumanCesitID);
        void Add(EnstrumanCesit enstrumanCesit);
        void Delete(int enstrumanCesitID);
        void Update(EnstrumanCesit enstrumanCesit);
    }
}
