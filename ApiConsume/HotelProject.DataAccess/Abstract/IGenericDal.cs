using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Inser(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);

    }
}
