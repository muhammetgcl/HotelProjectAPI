using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInser(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetById(int id);
    }
}
