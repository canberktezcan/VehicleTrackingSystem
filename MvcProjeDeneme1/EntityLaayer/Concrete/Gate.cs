using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Gate
    {
        [Key]
        public int GateID { get; set; }
        public double GateLat { get; set; }
        public double GateLng { get; set; }
    }
}
