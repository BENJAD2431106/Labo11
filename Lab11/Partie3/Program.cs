using System.Runtime.CompilerServices;

namespace Partie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Mission> missions = new List<Mission>();

            Planete planete = new Planete("Mars", 9999, 33, 45, 32334383, true);
            Planete planete1 = new Planete("Jupiter", 9999, 12, 12, 32336655556, true);

            int vit = rand.Next(20000, 35001);

            Vaisseau monVaisseau = new Vaisseau("JALEKS", 7, vit, 30000, false);

            Mission mission = monVaisseau.Decollage(33, 45, new DateOnly(2025, 09, 21));
            missions.Add(mission);

            FaireExploration(monVaisseau, planete, missions, mission);

            Console.WriteLine("Deuxième vaisseau *************************************************************");
            Console.WriteLine();
            ////deuxième vaisseau
            Vaisseau vaisseauTest = new Vaisseau("Test", 0, vit, 33333, false);

            Mission mission1 = vaisseauTest.Decollage(18, 99, new DateOnly(2010, 08, 09));
            missions.Add(mission1);

            FaireExploration(vaisseauTest, planete1, missions, mission1);

        }
        static void FaireExploration(Vaisseau vaisseau, Planete planete, List <Mission> missions, Mission mission)
        {
            if (vaisseau.aReussiDecollage==true)
            {
                planete.VerifierExplorerExc(missions);
                if (planete.VerifierExplorer(missions) == false)
                {
                    Console.WriteLine("Voulez-vous changer de vitesse? (O/N))");
                    char rep = Console.ReadKey().KeyChar;
                    Console.WriteLine("\n");
                    if (rep == 'O' || rep == 'o')
                    {
                        vaisseau.ChangerVitesse();
                    }
                    else
                        Console.WriteLine("Vitesse maintenue à " + vaisseau.ViteActuelle);


                    Console.WriteLine(vaisseau);
                    if(mission.DateArrive<= DateOnly.FromDateTime(DateTime.Now))
                    mission.CompleterMission();
                    else
                        Console.WriteLine("Déroulement prévu le "+mission.DateDepart+ " et arrivée prévue " +mission.DateArrive);
                }
                else
                    Console.WriteLine();
            }
            
        }
    }
}
