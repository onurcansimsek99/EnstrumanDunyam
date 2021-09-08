using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnstrumanDunyam.Interfaces
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        Blog Get();
        void Add(Blog blog);
        void Delete(int blogID);
        void Update(Blog blog);
    }
}
