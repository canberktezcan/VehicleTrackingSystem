using EntityLaayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayerr.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetList();
        void CustomerAdd(Customer customer);
        void CustomerDelete(Customer customer);
        void CustomerUpdate(Customer customer);
       // Customer GetbyID(int id);
    }
}
