using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie2
{
    public partial class Film
    {
        string Titre { get; set; }
        string Directeur { get; set; }
        int AnneeDeSortie { get; set; }
        List<String> Acteurs { get; set; }
        public Film(string titre, string directeur, int anneeDeSortie, string synopsis)
        {
            Titre = titre;
            Directeur = directeur;
            AnneeDeSortie = anneeDeSortie;
            Acteurs = new List<String>();
            Genres = new List<String>();
            Synopsis = synopsis;
        }
        string Synopsis { get; set; }
        List<string> Genres { get; set; }

        public override string ToString()
        {
            return "Le film : " + Titre + " est sortie en " + AnneeDeSortie + "\n" +
                " Son genre est "+Genres+" Directeur : "+Directeur+" et acteurs :"+Acteurs+"\n"+
                "Synopsis : "+Synopsis;
        }
    }
}
