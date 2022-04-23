using BuisnessLayerr.Abstract;
using DataAccessLayerr.Abstract;
using EntityLaayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayerr.Concrete
{
    public class GateManager : IGateService
    {

        IGateDal _gateDal;
        ICarsDal _carsDal;

        public GateManager(IGateDal gateDal)
        {
            _gateDal = gateDal;
        }

        public GateManager(ICarsDal carsDal)
        {
            _carsDal = carsDal;
        }

        public List<Gate> GetList()
        {
            return _gateDal.List();
        }
        public List<Cars> GetListCar()
        {
            return _carsDal.List();
        } 
        public List<Cars> GetListCustomerCar1()
        {
            return _carsDal.List();
        } 
        public List<Cars> GetListCustomerCar2()
        {
            return _carsDal.List();
        }

    }
}
