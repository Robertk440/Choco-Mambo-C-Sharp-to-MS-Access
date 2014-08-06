using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoMambo
{
    class Stock
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }
        public String Code { get; set; }
        public Decimal Price { get; set; }
        public long QtyOnHand { get; set; }
        public long QtyOnOrder { get; set; }
    }
}
