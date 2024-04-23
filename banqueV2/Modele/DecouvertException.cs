using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqueV2.Modele
{
    public class DecouvertException : Exception
    {

        public DecouvertException(string message) : base(message)
        {

        }
    }
}
