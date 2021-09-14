using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Blog:IEntity
    {
        [Key]
        public int BlogID { get; set; }

        [StringLength(100)]
        public string BlogBaslik { get; set; }

        [StringLength(1000)]
        public string BlogIcerik { get; set; }

        [StringLength(20)]
        public string BlogYazar { get; set; }

        public DateTime BlogYayinlanmaTarihi { get; set; }
    }
}
