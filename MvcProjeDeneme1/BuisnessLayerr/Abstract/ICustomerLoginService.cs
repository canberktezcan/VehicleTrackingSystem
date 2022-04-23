using EntityLaayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayerr.Abstract
{
    public interface ICustomerLoginService
    {
        Customer GetCustomer(string userName, string password);
    }
}
