using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IImageService
    {
        void Add(IFormFile file, Image image, int id);
        void Delete(Image image);
        void Update(IFormFile file, Image image);
        List<Image> GetImagesByEnstrumanID(int enstrumanID);
        List<Image> GetImagesByBlogID(int blogID);
    }
}
