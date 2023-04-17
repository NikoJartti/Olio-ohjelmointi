using Autos;
internal class Program
{
    private static void Main(string[] args)
    {
        Auto AutoOlio = new Auto();

        AutoOlio.Nimi = "BMW";
        AutoOlio.Nopeus = 125;
        AutoOlio.Renkaat = 5;

        Console.WriteLine(AutoOlio.TulostaData());
    }
}
