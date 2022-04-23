using DataAccessLayerr.Concrete.Repositories;
using EntityLaayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr.Abstract
{
   public interface IRepository<T>
    {
        List<T> List();
        //List<Cars> GetListCar(Expression<Func<T, bool>> filter);
        List<Cars> GetListCustomerCar1(int carID);
        List<Cars> GetListCustomerCar2(int carID);
        List<Cars> DateTimeBolme(int carID,DateTime year,DateTime yearson);


        void Insert(T p);
        T Get(Expression<Func<T, bool>> filter);
        void Update(T p);
        void Delete(T p);

        List<T> List(Expression<Func<T, bool>> filter);

        //void CarsAddToMongoDB(T p);
        //void ConnecttoMongoDB();

    }
}
