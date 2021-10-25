using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class JsonDataType
    {

        public bool success { get; set; }
        public List<Result> result { get; set; }
    }

    public class Result
    {
        public string name { get; set; }
        public string buying { get; set; }
        public string selling { get; set; }
    }
}
