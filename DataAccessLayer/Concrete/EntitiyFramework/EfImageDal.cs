using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntitiyFramework
{
    public class EfImageDal: GenericRepository<Image>, IImageDal
    {
    }
}
