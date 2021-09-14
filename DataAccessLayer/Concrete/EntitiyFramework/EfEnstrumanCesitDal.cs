using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete.EntitiyFramework
{
    public class EfEnstrumanCesitDal : GenericRepository<EnstrumanCesit>, IEnstrumanCesitDal
    {

        //    private Context _context = new Context();
        //    public void Add(EnstrumanCesit enstrumanCesit)
        //    {
        //        _context.EnstrumanCesits.Add(enstrumanCesit);
        //        _context.SaveChanges();
        //    }

        //    public void Delete(int enstrumanCesitID)
        //    {
        //        _context.EnstrumanCesits.Remove(_context.EnstrumanCesits.FirstOrDefault(p => p.EnstrumanCesitID == enstrumanCesitID));
        //        _context.SaveChanges();
        //    }

        //    public EnstrumanCesit Get(int enstrumanCesitID)
        //    {
        //        return _context.EnstrumanCesits.FirstOrDefault(p => p.EnstrumanCesitID == enstrumanCesitID);
        //    }

        //    public List<EnstrumanCesit> GetAll()
        //    {
        //        return _context.EnstrumanCesits.ToList();             //using System.Linq
        //    }

        //    public void Update(EnstrumanCesit enstrumanCesit)
        //    {
        //        EnstrumanCesit enstrumanCesitToUpdate = _context.EnstrumanCesits.FirstOrDefault(p => p.EnstrumanCesitID == enstrumanCesit.EnstrumanCesitID);

        //        enstrumanCesitToUpdate.EnstrumanCesitAdi = enstrumanCesit.EnstrumanCesitAdi;
        //        enstrumanCesitToUpdate.EnstrumanCesitAciklamasi = enstrumanCesit.EnstrumanCesitAciklamasi;

        //        _context.SaveChanges();

        //    }
        //}
    }
}
