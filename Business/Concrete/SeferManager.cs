using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SeferManager : ISeferService
    {
        ISeferDal _expeditionDal;

        public SeferManager(ISeferDal expeditionDal)
        {
            _expeditionDal = expeditionDal;
        }

        public void Add(Sefer expedition)
        {
            _expeditionDal.Add(expedition);
        }

        public void Delete(Sefer expedition)
        {
            _expeditionDal.Delete(expedition);
        }

        public List<Sefer> GetAll()
        {
            return _expeditionDal.GetAll();
        }

        public Sefer GetById(int id)
        {
            return _expeditionDal.Get(a => a.SeferId == id);
        }

        public string GetNereden(string nereden)
        {
            return _expeditionDal.GetNereden(nereden);
        }

        public string GetNereye(string nereye)
        {
            return _expeditionDal.GetNereye(nereye);
        }

        public int GetSeferByBslBts(string basl, string bts)
        {
            return _expeditionDal.GetSeferByBslBts(basl, bts);
        }

        public Sefer GetSeferDetails(int id)
        {
            return _expeditionDal.GetSeferDetails(id);
        }

        public List<Sefer> GetYolculuk(string nereden, string nereye)
        {
            return _expeditionDal.GetYolculuk(nereden, nereye);
        }

        public void Update(Sefer expedition)
        {
            _expeditionDal.Update(expedition);
        }
    }

}
