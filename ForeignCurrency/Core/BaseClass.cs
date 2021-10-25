using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class BaseClass
    {
        public void myTryCatch(Action action)
        {
            try
            {
                action();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
