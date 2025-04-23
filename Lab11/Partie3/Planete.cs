using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/// Code review des 3 parties fait par : Gabrielle Tremblay.
/// Remarques : Il fallait faire plusieurs classes
/// Réponse des étudiants (Alex & Jad) : On a fait une classe partielle et on travaillait sur la meme simultanément et une fois finie. on git...
namespace Partie3
{
    public partial class Planete
    {
        string Nom { get; set; }
        int Taille { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        double DistanceTerre { get; set; }
        bool Atmosphere { get; set; }
        public Planete(string nom, int taille, int x, int y, double distanceTerre, bool atmo)
        {
            Nom = nom;
            Taille = taille;
            DistanceTerre = distanceTerre;
            Atmosphere = atmo;
            X = x;
            Y = y;
        }
        public void VerifierExplorerExc(List<Mission> missions)
        {
            try
            {
                foreach (Mission mission in missions)
                {
                    try
                    {
                        if (mission.X == X && mission.Y == Y)
                        {
                            throw new ExceptionExploree("Mission deja programmée ou planète deja explorée !");
                        }
                    }
                    catch (NullReferenceException ex)
                    {
                    }
                }
            }
            catch (ExceptionExploree ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public bool VerifierExplorer(List<Mission> missions)
        {
            foreach (Mission mission in missions)
            {
                try
                {
                    if (mission.X == X && mission.Y == Y)
                    {
                        Console.WriteLine("Mais ...");
                        Console.WriteLine("La planète découverte visée est "+Nom);
                        return true;

                    }
                }
                catch (NullReferenceException ex)
                {
                }
            }

            return false;
        }

    }

}