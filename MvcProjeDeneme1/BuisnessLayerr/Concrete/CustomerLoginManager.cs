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
    public class CustomerLoginManager : ICustomerLoginService
    {
        ICustomerDal _customerDal;

        public CustomerLoginManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public Customer GetCustomer(string userName, string password)
        {
            return _customerDal.Get(x => x.CustomerUsername == userName && x.CustomerPassword == password);
        }
    }
}
