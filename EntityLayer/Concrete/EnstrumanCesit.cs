using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class EnstrumanCesit
    {
        [Key]
        public int EnstrumanCesitID { get; set; }

        [StringLength(20)]
        public string EnstrumanCesitAdi { get; set; }

        [StringLength(1000)]
        public string EnstrumanCesitAciklamasi { get; set; }


        public ICollection<Enstruman> Enstrumans { get; set; }                 //İlişki kurmak istediğim sınıfı <> içine yazıyoruz.
    }
}
