using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie2
{
    public partial class Film
    {
        string Synopsis { get; set; }
        List<string> Genres { get; set; }

        public override string ToString()
        {
            return $"Le film: {Titre}" ;
        }
    }
}
