using harjoitus_2_opiskelija;

internal class Program
{
    private static void Main(string[] args)
    {
        opiskelija OpiskelijaOlio = new opiskelija("Pekka", "21", 4);


        OpiskelijaOlio.Nimi = "Jonne";
        OpiskelijaOlio.OpiskelijaID = "100";
        OpiskelijaOlio.Opintopisteet = 4;

        Console.WriteLine(OpiskelijaOlio.TulostaData());

        OpiskelijaOlio.MuokkaaOpintopisteita();

        Console.WriteLine(OpiskelijaOlio.TulostaData());
    }
}