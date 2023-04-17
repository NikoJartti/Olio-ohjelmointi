using harjoitus_3_kt;

internal class Program
{
    private static void Main(string[] args)
    {
        Kiuas kiuasOlio = new Kiuas("harvia", 100, 90, "ei");


        kiuasOlio.Valmistaja = "harvia";
        kiuasOlio.lämpötila = 10;
        kiuasOlio.kosteus = 90;
        kiuasOlio.päällä = "ei";

        Console.WriteLine(kiuasOlio.TulostaData());

        Console.WriteLine("Paina ENTER, jos haluat kiukaan päälle");
        Console.ReadLine();

        kiuasOlio.Virta();

        kiuasOlio.MuokkaaLämpötilaa();

        Console.WriteLine(kiuasOlio.TulostaData());
    }
}