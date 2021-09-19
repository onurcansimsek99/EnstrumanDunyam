using BusinessLayer.Abstract;
using BusinessLayer.Helpers;
using DataAccessLayer.Concrete.EntitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class ImageManager : IImageService
    {

        EfImageDal _efImageDal = new EfImageDal();

        public void Add(IFormFile file, Image image, int id)
        {
            
            var imageResult=FileHelper.Add(file);

            
            image.ImagePath = imageResult;
            _efImageDal.Add(image);
        }

        public void Delete(Image image)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetImagesByBlogID(int blogID)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetImagesByEnstrumanID(int enstrumanID)
        {
            throw new NotImplementedException();
        }

        public void Update(IFormFile file, Image image)
        {
            throw new NotImplementedException();
        }
    }
}
