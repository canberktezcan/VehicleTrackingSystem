using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLaayer.Concrete
{
   public  class Customer
    {
       
        
        //[StringLength(50)]
        //public String CustomerName { get; set; }
        //[StringLength(50)]
        //public String CustomerSurname { get; set; }
        //[StringLength(50)]
          [Key]
        [StringLength(50)]
        public String CustomerUsername { get; set; }
        [StringLength(50)]
        public String CustomerPassword { get; set; }
        public DateTime CustomerLoginTime { get; set; }
        public DateTime CustomerLogoutTime { get; set; }

        public ICollection<Cars> cars { get; set; } 
    }
}
