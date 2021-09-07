using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete.EntitiyFramework
{
    public class EfSliderDal : ISliderDal
    {
        private Context _context = new Context();
        public void Add(Slider slider)
        {
            _context.Sliders.Add(slider);
            _context.SaveChanges();
        }

        public void Delete(int sliderID)
        {
            _context.Sliders.Remove(_context.Sliders.FirstOrDefault(p => p.SliderID == sliderID));
            _context.SaveChanges();
        }

        public Slider Get(int sliderID)
        {
            return _context.Sliders.FirstOrDefault(p => p.SliderID == sliderID);
        }

        public List<Slider> GetAll()
        {
            return _context.Sliders.ToList();
        }

        public void Update(Slider slider)
        {
            Slider sliderToUpdate = _context.Sliders.FirstOrDefault(p => p.SliderID == slider.SliderID);

            sliderToUpdate.SliderBaslik = slider.SliderBaslik;
            sliderToUpdate.SliderGorsel = slider.SliderGorsel;
            sliderToUpdate.SliderAciklama = slider.SliderAciklama;
        }
    }
}
