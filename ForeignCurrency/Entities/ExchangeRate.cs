using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ExchangeRate
    {
        public Guid ID { get; set; }

        public Guid CurrencyID { get; set; }

        public decimal Buyying { get; set; }
        public decimal Selling { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
