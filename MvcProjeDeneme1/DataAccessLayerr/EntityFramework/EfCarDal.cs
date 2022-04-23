using DataAccessLayerr.Abstract;
using DataAccessLayerr.Concrete.Repositories;
using EntityLaayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr.EntityFramework
{
    public class EfCarDal : GenericRepository<Cars>, ICarsDal
    {

    }
}
