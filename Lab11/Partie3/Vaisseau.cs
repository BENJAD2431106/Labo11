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
        public int ViteActuelle { get; set; }
        int VitMax { get; set; }
        public bool Orbite { get; set; }
        Mission mission;
        public bool aReussiDecollage = false;
        private int dernierX;
        private int dernierY;
        public Vaisseau(string nom, int capacite, int viteActuelle, int vitMax, bool orbite)
        {
            Nom = nom;
            Capacite = capacite;
            ViteActuelle = viteActuelle;
            VitMax = vitMax;
            Orbite = orbite;
            
        }
        public Mission Decollage(int x, int y, DateOnly date)
        {  
            dernierX = x;
            dernierY = y;
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
                        mission = new Mission(nom, x, y, date, dateArv, Status.Planifiee);
                    }
                    else if (date < DateOnly.FromDateTime(DateTime.Now) && dateArv > date)
                    {
                         mission = new Mission(nom, x, y, date, dateArv, Status.Encours);
                    }
                    else
                    {
                         mission = new Mission(nom, x, y, date, dateArv, Status.Terminee);
                    }
                    aReussiDecollage = true;
                }
            }
            catch (ExceptionOrbite ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (decollage == true)
                    Console.WriteLine("Décollage possible !");
                else
                    Console.WriteLine("Décollage impossible / échoué");
            }
            return mission;
        }
        public void ChangerVitesse()
        {
            try
            {
                int nouvelleVitesse = rand.Next(20000, 35001);
                if (nouvelleVitesse >= ViteActuelle)
                    throw new ExceptionVitese("La vitesse demandée dépasse la vitesse maximale du vaisseau");
                else
                    Console.WriteLine("Vitesse passée de : " + ViteActuelle + " à : " + nouvelleVitesse);
                    ViteActuelle = nouvelleVitesse;    
            }
            catch (ExceptionVitese exVit)
            {
                Console.WriteLine(exVit.Message);
            }
        }
        public override string ToString()
        {

            if (aReussiDecollage)
            {
                return "Vaisseau " + Nom + " a réussi son décollage en direction de X : " + dernierX + " et Y : " + dernierY;
            }
            else
                return "Au final, pas décollage pour le Vaisseau "+Nom;
                
        }
    }
}
