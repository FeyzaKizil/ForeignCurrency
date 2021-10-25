using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Currency
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public decimal LimitAlert { get; set; }
    }
}
