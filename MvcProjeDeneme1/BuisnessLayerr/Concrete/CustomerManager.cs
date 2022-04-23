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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        //public Customer GetCarIDbyUsername(string s)
        //{
        //    return _customerDal.Get(x => x.CustomerUsername == s);
        //}

        public List<Customer> GetList()
        {
            return _customerDal.List();
        }

        public void CustomerAdd(Customer customer)
        {
            _customerDal.Insert(customer);
        }

        public void CustomerDelete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public void CustomerUpdate(Customer customer)
        {
            _customerDal.Update(customer);
        }

        
    }
}
