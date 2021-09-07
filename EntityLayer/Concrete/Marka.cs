using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Marka
    {
        [Key]
        public int MarkaID { get; set; }

        [StringLength(20)]
        public string MarkaAdi { get; set; }

        public ICollection<Enstruman> Enstrumans { get; set; }       //İlişki kurmak istediğim sınıfı <> içine yazıyoruz.

    }
}
