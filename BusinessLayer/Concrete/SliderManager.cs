using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        EfSliderDal _sliderDal = new EfSliderDal();

        //public SliderManager()
        //{
        //}

        //public SliderManager(ISliderDal sliderDal)
        //{
        //    _sliderDal = sliderDal;
        //}

        public void Add(Slider slider)
        {
            _sliderDal.Add(slider);
        }

        public void Delete(Slider slider)
        {
            _sliderDal.Delete(slider);
        }

        public Slider Get(int sliderID)
        {
            return _sliderDal.Get(i=>i.SliderID==sliderID);
        }

        public List<Slider> GetAll()
        {
            return _sliderDal.GetAll();
        }

        public void Update(Slider slider)
        {
            _sliderDal.Update(slider);
        }
    }
}
