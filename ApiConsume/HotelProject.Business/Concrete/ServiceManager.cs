using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TInser(Service t)
        {
            _serviceDal.Inser(t);
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
