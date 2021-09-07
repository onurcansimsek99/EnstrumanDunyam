using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Slider
    {
        [Key]
        public int SliderID { get; set; }

        [StringLength(200)]
        public string SliderBaslik { get; set; }

        [StringLength(400)]
        public string SliderAciklama { get; set; }

        [StringLength(100)]
        public string SliderGorsel { get; set; }
        
    }
}
