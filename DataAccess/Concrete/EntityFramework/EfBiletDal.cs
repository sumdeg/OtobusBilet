using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBiletDal : EfEntityRepositoryBase<Bilet, BiletSistemDBContext>, IBiletDal
    {
      
        public int GetCountByKoltuk(int seferId)
        {
            using (var context = new BiletSistemDBContext())
            {
                return context.Biletler
                    .Where(i => i.SeferId == seferId)
                    .Select(i => i.KoltukNo)
                    .Count();
            }
        }

        public decimal GetFiyat(int id)
        {
            using (var context = new BiletSistemDBContext())
            {
                var sonbiletfiyat = context.Seferler
                    .Where(i => i.SeferId == id)
                    .Select(i => i.SeferUcret)
                    .FirstOrDefault();

                return sonbiletfiyat;
            }
        }

        public int GetId()
        {
            using (var context = new BiletSistemDBContext())
            {
                var id = context.Biletler
                    .OrderByDescending(i => i.BiletId)
                    .Select(i => i.SeferId)
                    .FirstOrDefault();
                return id;
            }
        }

        public List<int> GetKoltuk(int seferId)
        {
            using (var context = new BiletSistemDBContext())
            {
                var koltuk = context.Biletler
                    .Where(i => i.SeferId == seferId)
                    .Select(i => i.KoltukNo)
                    .ToList();

                return koltuk;
            }
        }

        public string GetSaat(int id)
        {
            using (var context = new BiletSistemDBContext())
            {
                var sonbiletsaat = context.Seferler
                    .Where(i => i.SeferId == id)
                    .Select(i => i.KalkisZamani)
                    .FirstOrDefault();

                return sonbiletsaat;
            }
        }

    
        public Bilet GetSonKayit()
        {
            using (var context = new BiletSistemDBContext())
            {
                var sonbilet = context.Biletler
                    .OrderByDescending(i => i.BiletId)
                    .FirstOrDefault();
                return sonbilet;
            }
        }

        public string GetTarih(int id)
        {
            using (var context = new BiletSistemDBContext())
            {
                var sonbilettarih = context.Seferler
                    .Where(i => i.SeferId == id)
                    .Select(i => i.SeferTarihi)
                    .FirstOrDefault();

                return sonbilettarih;
            }
        }
    }

}
