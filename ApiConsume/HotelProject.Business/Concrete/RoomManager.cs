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
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomdal;

        public RoomManager(IRoomDal roomdal)
        {
            _roomdal = roomdal;
        }

        public void TDelete(Room t)
        {
            _roomdal.Delete(t);
        }

        public Room TGetById(int id)
        {
            return _roomdal.GetById(id);
        }

        public List<Room> TGetList()
        {
            return _roomdal.GetList();
        }

        public void TInser(Room t)
        {
            _roomdal.Inser(t);
        }

        public void TUpdate(Room t)
        {
            _roomdal.Update(t);
        }
    }
}
