using EntityLaayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Customer> CustomersTable { get; set; }
        public DbSet<Cars> CarsTable { get; set; }

    }
}
