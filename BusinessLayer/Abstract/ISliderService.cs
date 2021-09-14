using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ISliderService
    {
        List<Slider> GetAll();
        Slider Get(int sliderID);
        void Add(Slider slider);
        void Delete(Slider slider);
        void Update(Slider slider);
    }
}
