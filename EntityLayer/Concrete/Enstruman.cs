using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Enstruman:IEntity
    {
        [Key]
        public int EnstrumanID { get; set; }

        [StringLength(20)]
        public string EnstrumanAdi { get; set; }

        [StringLength(100)]
        public string EnstrumanGorsel {get; set;}

        [StringLength(20)]
        public string EnstrumanTuru { get; set; }

        [StringLength(20)]
        public string EnstrumanMarkasi { get; set; }
        public int EnstrumanFiyati { get; set; }
        public bool OneCikanMi { get; set; }
        public DateTime EnstrumanYuklemeTarihi { get; set; }


        public int EnstrumanCesitID { get; set; }
        public virtual EnstrumanCesit EnstrumanCesit { get; set; }

        public ICollection<Image> Images { get; set; }


        public int MarkaID { get; set; }
        public virtual Marka Marka { get; set; }


       
    }
}
