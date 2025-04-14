using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie2
{
    public partial class Production
    {
        public Production()
        {
            Catalogue catalogue = new Catalogue();
            Film film1 = new Film("Among Us", "Oleks", 2023, "Un homme dans l'eau va nager et se noir...");
            Film film2 = new Film("La partie fantome", "Jad", 2018, "Des vacances ruinées à cause d'un jeu d'horreur.");

        }
    }
}
