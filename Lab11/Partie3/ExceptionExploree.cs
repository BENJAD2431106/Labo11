using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
    public class ExceptionExploree : Exception
    {
        public ExceptionExploree(string message) : base(message)
        {

        }
        public int ErrorCode { get; set; }
    }
}
