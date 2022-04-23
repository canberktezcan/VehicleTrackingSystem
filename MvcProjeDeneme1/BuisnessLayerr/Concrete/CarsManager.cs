using BuisnessLayerr.Abstract;
using DataAccessLayerr.Abstract;
using EntityLaayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayerr.Concrete
{
    public class CarsManager : ICarsService
    {

        ICarsDal _carsDal;

        public CarsManager(ICarsDal carsDal)
        {
            _carsDal = carsDal;
        }

        public Cars getCarsID(string username)
        {
            return _carsDal.Get(x => x.CustomerUsername == username);
        }
        public List<Cars> GetListCar(string username)
        {
            return _carsDal.List(x=>x.CustomerUsername == username);
        }

        public List<Cars> GetListCustomerCar1(int carID)
        {
            return _carsDal.GetListCustomerCar1(carID);
        }
        public List<Cars> GetListCustomerCar2(int carID)
        {
            return _carsDal.GetListCustomerCar2(carID);
        }
        public List<Cars> DateTimeBolme(int carID,DateTime year,DateTime yearson)
        {
            return _carsDal.DateTimeBolme(carID,year,yearson);
        }

       


    }
}
