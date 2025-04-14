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
