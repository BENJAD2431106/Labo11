using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
    public partial class Vaisseau
    {
        public double ChangerVitesse()
        {
            try
            {
                double nouvelleVitesse = 0;
                if (nouvelleVitesse >= Vitesse)
                    throw new ExceptionVitese("La vitesse demandée dépasse la vitesse maximale du vaisseau");
                else
                    Vitesse = nouvelleVitesse;
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
