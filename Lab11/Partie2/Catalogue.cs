using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie2
{
    public partial class Catalogue
    {
        List<Film> films = new List<Film>();
        public Catalogue()
        {
            films = new List<Film>();
        }
        public void AddFilm(Film film)
        {
            films.Add(film);
        }
        public void DeleteFilms(Film film)
        {
            films.Remove(film);
        }
        public void RechecherParTitre()
        {
            Console.WriteLine("Quel film voulez-vous rechercher? ");
            string choix = Console.ReadLine();
            foreach (var filmRech in films)
            {
                if (choix == filmRech.Titre)
                {
                    Console.WriteLine(filmRech);
                }
                else { Console.WriteLine("Ce film n'existe pas ou son titre est mal écrit.\n Veuillez reéssayer "); }
            }
        }

        public void RechecherParActeur()
        {
            //Console.WriteLine("À l'aide de quel auteur voulez-vous rechercher un film? ");
            //string choix = Console.ReadLine();
            //foreach (var filmRech in films)
            //{
            //    foreach (var auteur in films.Auteurs)
            //    {
            //        if (choix == filmRech.Auteurs)
            //        {
            //            Console.WriteLine(filmRech);
            //        }
            //        else { Console.WriteLine("Ce film n'existe pas ou son auteur est introuvable.\n Veuillez reéssayer "); }
        //        }
        //    }
        }
        public string GetInfos()
        {
            string infos = "";
            foreach (Film film in films)
            {
                infos += film.ToString();
                infos += "\n";
            }
            return infos;
        }
        public override string ToString()
        {
            return GetInfos();
        }
    }
}