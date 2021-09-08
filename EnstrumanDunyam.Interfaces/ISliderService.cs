using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnstrumanDunyam.Interfaces
{
    public interface ISliderService
    {
        List<Slider> GetAll();
        Slider Get();
        void Add(Slider slider);
        void Delete(int sliderID);
        void Update(Slider slider);
    }
}
