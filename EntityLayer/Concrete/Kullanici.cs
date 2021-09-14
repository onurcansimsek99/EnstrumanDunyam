using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Kullanici: IEntity
    {
        [Key]
        public int KullaniciID { get; set; }

        [StringLength(30)]
        public string KullaniciAdi { get; set; }

        [StringLength(20)]
        public string KullaniciSifre { get; set; }
    }
}
