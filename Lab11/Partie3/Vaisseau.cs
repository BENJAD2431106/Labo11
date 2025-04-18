using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
    public partial class Vaisseau
    {
        Random rand = new Random();
        string Nom { get; set; }
        int Capacite { get; set; }
        int ViteActuelle { get; set; }
        int VitMax { get; set; }
        bool Orbite { get; set; }
        List<Mission> missions = new List<Mission>();
        public Vaisseau(string nom, int capacite, int viteActuelle, int vitMax, bool orbite)
        {
            Nom = nom;
            Capacite = capacite;
            ViteActuelle = viteActuelle;
            VitMax = vitMax;
            Orbite = orbite;
            missions = new List<Mission>();
        }
        public void Decollage(int x, int y, DateOnly date)
        {            
            string nom = "mission";
            int nombre = rand.Next(1, 13434234);
            int duree = rand.Next(0, 56);
            nom += nombre;
            bool decollage = false;
            DateOnly dateArv = date.AddYears(duree);
            try
            {
                if (Orbite == true)
                    throw new ExceptionOrbite("Vaisseau deja en orbite...");
                else
                {
                    Orbite = true;
                    decollage = true;
                    if (date >= DateOnly.FromDateTime(DateTime.Now))
                    {
                        Mission mission = new Mission(nom, x, y, date, dateArv, Status.Planifiee);
                        missions.Add(mission);
                    }
                    else if (date < DateOnly.FromDateTime(DateTime.Now) && dateArv > date)
                    {
                        Mission mission = new Mission(nom, x, y, date, dateArv, Status.Encours);
                        missions.Add(mission);
                    }
                    else
                    {
                        Mission mission = new Mission(nom, x, y, date, dateArv, Status.Terminee);
                        missions.Add(mission);
                    }
                }
            }
            catch (ExceptionOrbite ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (decollage == true)
                    Console.WriteLine("Décollage réussi !");
                else
                    Console.WriteLine("Décollage échoué");
            }
        }
        public void ChangerVitesse()
        {
            try
            {
                int nouvelleVitesse = rand.Next(20000, 35001);
                if (nouvelleVitesse >= ViteActuelle)
                    throw new ExceptionVitese("La vitesse demandée dépasse la vitesse maximale du vaisseau");
                else
                    ViteActuelle = nouvelleVitesse;
            }
            catch (ExceptionVitese exVit)
            {
                Console.WriteLine(exVit.Message);
            }
            finally
            {
                Console.WriteLine("Le changement d'une vitesse a été fait");
            }
        }
    }
}
