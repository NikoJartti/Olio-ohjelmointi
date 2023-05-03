using Eläimet;

internal class Program
{
    private static void Main(string[] args)
    {

            Eläin eläin1 = new Eläin();
            Eläin eläin2 = new Kissa();
            Eläin eläin3 = new Koira();
           

            Console.WriteLine("Eläimiä yhteensä: " + Eläin.MontaEläintä());
            Console.WriteLine(eläin1.Ääni());
            Console.WriteLine(eläin2.Ääni());
            Console.WriteLine(eläin3.Ääni());
            
        
    }
}