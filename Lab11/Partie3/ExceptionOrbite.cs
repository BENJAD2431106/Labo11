using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
    class ExceptionOrbite : Exception
    {
        public ExceptionOrbite(string message) : base(message) 
        {

        }
        public int ErrorCode { get; set; }
    }
}
