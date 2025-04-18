using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
    public partial class Vaisseau
    {
        string Nom { get; set; }
        int Capacite { get; set; }
        int ViteActuelle { get; set; }
        int VitMax { get; set; }
        bool Orbite { get; set; }
        public Vaisseau(string nom, int capacite, int viteActuelle, int vitMax, bool orbite)
        {
            Nom = nom;
            Capacite = capacite;
            ViteActuelle = viteActuelle;
            VitMax = vitMax;
            Orbite = orbite;
        }
        public void Decollage(int x, int y, DateTime date)
        {
            List<string> missions = new List<string>();
            bool decollage = false;
            string mission = "";
            try
            {
                if (Orbite == false)
                    throw new ExceptionOrbite("Vaisseau deja en orbite...");
                else
                {
                    Orbite = false;
                    mission += " Fusée " + Nom + " va vers -> X: " + x + " Y: " + y + " Le " + date;
                    missions.Add(mission);
                    decollage = true;
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
                int nouvelleVitesse = 0;
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
