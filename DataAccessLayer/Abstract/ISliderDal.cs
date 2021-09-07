using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ISliderDal
    {
        List<Slider> GetAll();
        Slider Get(int sliderID);
        void Add(Slider slider);
        void Delete(int sliderID);
        void Update(Slider slider);
    }
}
