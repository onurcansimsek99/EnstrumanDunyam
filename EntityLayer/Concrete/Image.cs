using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Image:IEntity
    {
        [Key]
        public int ImageID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ImagePath { get; set; }

        public int EnstrumanID { get; set; }
        public virtual Enstruman Enstruman { get; set; }

        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }





       
        
    }
}
