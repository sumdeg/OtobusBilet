using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISeferDal : IEntityRepository<Sefer>
    {
        string GetNereden(string nereden);
        string GetNereye(string nereye);
        List<Sefer> GetYolculuk(string nereden, string nereye);
        int GetSeferByBslBts(string basl, string bts);
        Sefer GetSeferDetails(int id);

    }

}
