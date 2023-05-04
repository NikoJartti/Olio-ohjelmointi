using harjoitus_12;

class korttipakka
{
    static void Main()
    {

        Korttipakka pakka = new Korttipakka();

        Console.WriteLine("Pakka ei ole sekoitettu");
        pakka.TulostaKortit();



        pakka.SekoitaKortit();

        Console.WriteLine("\nKortit on sekoitettu:");

        pakka.TulostaKortit();


    }
}