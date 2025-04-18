    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie2
{
    public partial class Film
    {
        public string Titre { get; set; }
        string Directeur { get; set; }
        int AnneeDeSortie { get; set; }
        public List<String> Acteurs { get; set; }
        string Synopsis { get; set; }
        List<string> Genres { get; set; }
        public Film(string titre, string directeur, int anneeDeSortie, string synopsis, List<string> acteurs, List<string> genres)
        {
            Titre = titre;
            Directeur = directeur;
            AnneeDeSortie = anneeDeSortie;
            Acteurs = acteurs;
            this.Genres = genres;
            Synopsis = synopsis;
        }
        public string GetInfoGenres()
        {
            string info = "";
            foreach (string genre in Genres)
            {
                info += genre + " ";
            }
            return info;
        }

        public string GetInfoActeurs()
        {
            string info = "";
            foreach (string acteur in Acteurs)
            {
                info += acteur + " ";
            }
            return info;
        }
        public override string ToString()
        {
            return "Le film : " + Titre + " est sortie en " + AnneeDeSortie + "\n" +
                " Son genre est "+ GetInfoGenres() +" Directeur : "+ Directeur +" et acteurs :"+ GetInfoActeurs() +"\n"+
                "Synopsis : "+ Synopsis
                +"\n";
        }
    }
}
