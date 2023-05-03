using harjoitus_7;

internal class Program
{
    private static void Main(string[] args)
    {
        Hissi hissi = new Hissi();

        while (true)
        {
            Console.WriteLine();
            Console.Write("Anna uusi kerros (1-6): ");
            string input = Console.ReadLine();
            int kerros;

            if (int.TryParse(input, out kerros))
            {
                hissi.Kerros = kerros;
            }
            else
            {
                Console.WriteLine("ERRORR! ! !...");
            }
        }
    }
}