using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISeferService
    {
        void Add(Sefer expedition);
        void Update(Sefer expedition);
        void Delete(Sefer expedition);
        List<Sefer> GetAll();
        Sefer GetById(int id);
        string GetNereden(string nereden);
        string GetNereye(string nereye);
        List<Sefer> GetYolculuk(string nereden, string nereye);
        int GetSeferByBslBts(string basl, string bts);
        Sefer GetSeferDetails(int id);
    }

}
