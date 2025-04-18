using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Partie2
{
    public partial class Production
    {
        Catalogue catalogue = new Catalogue();
        public Production()
        {
            this.catalogue = new Catalogue();
            Film film1 = new Film("Among Us", "Oleks", 2023, "Un homme dans l'eau va nager et se noir...", ["Oleks","Jad","Vincent"], ["Drama", "Comedie"]);
            Film film2 = new Film("La partie fantome", "Jad", 2018, "Des vacances ruinées à cause d'un jeu d'horreur.", ["Oleks", "Jad", "Francis"], ["Horreur", "Action", "Survie"]);
            Film film3 = new Film("LOL", "Vincent", 1999, "Du rire à l'ancienne !", ["Vincent", "Jimmy", "Martin"], ["Comedie", "Action"]);
            catalogue.AddFilm(film1);
            catalogue.AddFilm(film2);
            catalogue.AddFilm(film3);
            catalogue.GetInfos();

        }
        public void RechActeur()
        {
             catalogue.RechecherParActeur();
        }
        public void RechTitre()
        {
            catalogue.RechecherParTitre();
        }
    }
}
