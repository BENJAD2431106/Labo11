using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
    internal class Planete
    {
        string Nom { get; set; }
        int Taille { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        double DistanceTerre { get; set; }
        bool Atmosphere { get; set; }
        public Planete(string nom, int taille, double distanceTerre, bool atmo)
        {
            Nom = nom;
            Taille = taille;
            DistanceTerre = distanceTerre;
            Atmosphere = atmo;
        }
        public void VerifierExplorer(List<Mission> missions)
        {
            try
            {
                foreach (Mission mission in missions)
                {
                    if (mission.X == X && mission.Y == Y)
                    {
                        throw new ExceptionExploree("Mission deja programmée ou planète deja explorée !");
                    }
                }
            }
            catch (ExceptionExploree ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}