using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class GateManager : IGateService
    {
       IGateDal _gateDal;

        public GateManager(IGateDal gateDal)
        {
            _gateDal = gateDal;
        }

        public List<Gate> GetList()
        {
            return _gateDal.List();   
        }
    }
}
