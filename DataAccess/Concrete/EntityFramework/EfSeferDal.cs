using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSeferDal : EfEntityRepositoryBase<Sefer, BiletSistemDBContext>, ISeferDal
    {
        public string GetNereden(string nereden)
        {
            using (var context = new BiletSistemDBContext())
            {
                var nrdn = context.Sehirler
                    .Where(i => i.SehirId == Convert.ToInt32(nereden))
                    .Select(i => i.SehirAdi)
                    .ToList();
                return nrdn[0];
            }
        }

        public string GetNereye(string nereye)
        {
            using (var context = new BiletSistemDBContext())
            {
                var nry = context.Sehirler
                    .Where(i => i.SehirId == Convert.ToInt32(nereye))
                    .Select(i => i.SehirAdi)
                    .ToList();
                return nry[0];
            }
        }

        public int GetSeferByBslBts(string basl, string bts)
        {
            throw new NotImplementedException();
        }

        public Sefer GetSeferDetails(int id)
        {
            using (var context = new BiletSistemDBContext())
            {
                return context.Seferler
                    .Where(i => i.SeferId == id)
                    .AsNoTracking()
                    .FirstOrDefault();
            }
        }

        public List<Sefer> GetYolculuk(string nereden, string nereye)
        {
            using (var context = new BiletSistemDBContext())
            {
                var nrdn = context.Sehirler
                    .Where(i => i.SehirId == Convert.ToInt32(nereden))
                    .Select(i => i.SehirAdi)
                    .ToList();
                var nry = context.Sehirler
                    .Where(i => i.SehirId == Convert.ToInt32(nereye))
                    .Select(i => i.SehirAdi)
                    .ToList();
                var guzergahs = context.Seferler
                    .FromSqlRaw($"select * from Seferler where ((KalkisSehir='{nrdn[0]}') and (VarisSehir='{nry[0]}')) ")
                    .ToList();

                return guzergahs;

            }
        }
    }

}
