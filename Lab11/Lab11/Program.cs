namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entree1 = 0;
            int entree2 = 0;
            Calculateur clc = new Calculateur();
            Console.WriteLine("Bonjour! Entrez un nombre");
            try
            {
                entree1 = int.Parse(Console.ReadLine());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Bonjour! Entrez un deuxième nombre");
            try
            {
                entree2 = int.Parse(Console.ReadLine());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine("Multiplication : " + clc.Multiplier(entree1, entree2));
                Console.WriteLine("Division : " + clc.Diviser(entree1, entree2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("On ne peut pas diviser par un nombre nul.");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur...");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Try executé avec succès");
            }
        }
    }
}
