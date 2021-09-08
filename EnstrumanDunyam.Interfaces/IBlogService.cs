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
        public List<Blog> GetAll();
        public Blog Get(int blogID);
        public void Add(Blog blog);
        public void Delete(int blogID);
        public void Update(Blog blog);
    }
}
