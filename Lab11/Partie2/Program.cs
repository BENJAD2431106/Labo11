namespace Partie2
{
    internal class Program
    {
        static void AfficherOuiUtilisateur(Production production)
        {
            char rep1;
            do
            {
                Console.WriteLine("Faire une recherche par (T)itre ou par (A)cteur ?");
                rep1 = Console.ReadKey().KeyChar;
                if (char.ToLower(rep1) == 't')
                {
                    Console.WriteLine();
                    production.RechTitre();
                }
                else if (char.ToLower(rep1) == 'a')
                {
                    Console.WriteLine();
                    production.RechActeur();
                }
            } while (char.ToLower(rep1) == 'a' || char.ToLower(rep1) == 't');
        }

        static void Main(string[] args)
        {
            Production production = new Production();
            char rep;
            do
            {
                Console.WriteLine("Souhaitez-vous rechercer un film ?((O)ui/(N)on)");
                rep = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                if (char.ToLower(rep) == 'o')
                {
                    AfficherOuiUtilisateur(production);
                }
                else if(char.ToLower(rep) == 'n')
                {
                    Console.WriteLine("Appuyez sur une touche quelconque pour arreter...");
                    Console.ReadLine();
                }
                else { Console.WriteLine("Touche incorrecte."); }
            } while (char.ToLower(rep) != 'o' || char.ToLower(rep) != 'n');
        }
    }
}
