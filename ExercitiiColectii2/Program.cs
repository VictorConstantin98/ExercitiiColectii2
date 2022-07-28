using System;
namespace ExercitiiColectii2
{
    class Program
    {
        static void Main(string[] args)
        {
            Preturi preturiKaufland = new Preturi();

            preturiKaufland.adaugarePret(33);
            preturiKaufland.adaugarePret(25.40);

            double pretCocaCola = 7.60;
            preturiKaufland.adaugarePret(pretCocaCola);
            Console.WriteLine($"Preturi Kaufland: {preturiKaufland}");
            preturiKaufland.afisareListaPreturi();

            Console.WriteLine("\n");

            Console.WriteLine(preturiKaufland.ToString());

            Console.WriteLine("\n");

            preturiKaufland.stergerePrimulElement();
            preturiKaufland.stergereUltimulElement();
            Console.WriteLine(preturiKaufland.ToString());

            preturiKaufland.adaugarePret(pretCocaCola);
            preturiKaufland.adaugarePret(pretCocaCola);
            preturiKaufland.adaugarePret(28.99);
            preturiKaufland.adaugarePret(35.25);
            preturiKaufland.adaugarePret(41.02);

            Console.WriteLine("\n");
            preturiKaufland.sortareListaDePreturiCrescator();
            Console.WriteLine(preturiKaufland.ToString());

            preturiKaufland.sortareListaDePreturiDescrescator();
            Console.WriteLine(preturiKaufland.ToString());

            Console.WriteLine("\n");

            Console.WriteLine(preturiKaufland.getElementAt(2));
            Console.WriteLine(preturiKaufland.getElementAt(preturiKaufland.countPreturi() - 2));

            Console.WriteLine("\n");

            if (preturiKaufland.getElementAt(2) < preturiKaufland.getElementAt(preturiKaufland.countPreturi()-2))
            {
                Console.WriteLine(preturiKaufland.countPreturi() - 2);
            }
            else
            {
                Console.WriteLine(2);
            }

            List<double> rezultat = preturiKaufland.getListaPreturiAbove(26);
            Console.WriteLine(rezultat.Count());
            
            foreach(double element in rezultat)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\n");
            Console.WriteLine(preturiKaufland.getNumberOfElementsBelow(41.02));
            Console.WriteLine(preturiKaufland.sumWithoutMin());

            List<double> rezultat2 = preturiKaufland.getListaPreturiAbove(7.6);
            Console.WriteLine(rezultat2.Sum());

            Console.WriteLine("\n");
            Console.WriteLine(preturiKaufland.getNumberOfElementsBelow(41.02));
            Console.WriteLine(preturiKaufland.ToString());

            Console.WriteLine("\n");
            Console.WriteLine(preturiKaufland.mediaCelorMaiMariTreiElemente());
            Console.WriteLine(preturiKaufland.ToString());
        }
    }
}
