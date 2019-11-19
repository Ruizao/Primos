using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Primos
    {
        private DateTime data;
        public string recebe
        {
            set
            {
                data = Convert.ToDateTime(value);
            }
        }
        public string envia
        {
            get
            {
                return data.ToString("dddddd");
            }
        }
    }
}
