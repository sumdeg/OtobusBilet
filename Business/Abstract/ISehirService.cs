using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISehirService
    {
        void Add(Sehir city);
        void Update(Sehir city);
        void Delete(Sehir city);
        List<Sehir> GetAll();
        Sehir GetById(int id);
    }

}
