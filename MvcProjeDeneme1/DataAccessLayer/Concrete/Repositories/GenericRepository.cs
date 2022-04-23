using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>(); //dışarıdan gelen t değerini burda kendisine göre ayrıp oobjeye atıyoruz
        }
        public List<T> List()
        {
            return _object.ToList(); throw new NotImplementedException();
        }
    }
}
