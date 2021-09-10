using DataAccessLayer.Abstract;
using EnstrumanDunyam.Interfaces;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        private ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void Add(Slider slider)
        {
            _sliderDal.Add(slider);
        }

        public void Delete(int sliderID)
        {
            _sliderDal.Delete(sliderID);
        }

        public Slider Get(int sliderID)
        {
            return _sliderDal.Get(sliderID);
        }

        public List<Slider> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Slider slider)
        {
            throw new NotImplementedException();
        }
    }
}
