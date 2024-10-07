internal class Program
{
   static bool run = true;

    static void Main(string[] args)
    {

        while (run)
        {

            Console.Write("Kies uit onder welk BTW tarief uw product valt" +
                "\n1. 21%" +
                "\n2. 9%\n\n");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    Console.Clear();
                    Console.WriteLine("Vul een prijs in\n");
                    string prijs = Console.ReadLine();

                    calculateInput(prijs, 0.21);

                    break;

                case "2":

                    Console.Clear();
                    Console.WriteLine("Vul een prijs in\n");
                    prijs = Console.ReadLine();

                    calculateInput(prijs, 0.09);

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ongeldige keuze!");
                    ContinueOrClose();
                    break;
            }
        }
    }

    static void calculateInput(string prijs, double BTWCalculation)
    {
        double result;
        double prijsNum;

        if (double.TryParse(prijs, out prijsNum))
        {
            double BTW = prijsNum * BTWCalculation;
            double prijsNetto = prijsNum + BTW;

            Console.Clear();
            Console.WriteLine($"De prijs inclusief BTW: {prijsNetto}\n" +
                $"De prijs exlusief BTW: {prijsNum}\n" +
                $"Wat u aan BTW betaald: {BTW:F2} \n");
                ContinueOrClose();

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Ongeldige invoer");
            ContinueOrClose();
        }

    }

    static void ContinueOrClose()
    {
        Console.WriteLine($"\n\n");
        Console.WriteLine($"Druk op X om af te sluiten of een andere toets om door te gaan\n");

        string input = Console.ReadLine();

        if (input?.ToLower() == "x")
        {
            run = false;
        }
    }   
}

