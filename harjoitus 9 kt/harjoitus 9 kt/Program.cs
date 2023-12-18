class Radio
{
    private bool paalla;        // Radio päällä tai pois päältä
    private int aanenvoimakkuus; // Äänenvoimakkuuden taso (0-9)
    private double taajuus;      // Radion taajuus (88.0-107.9)

    //asetetaan oletusarvot
    public Radio()
    {
        paalla = false;
        aanenvoimakkuus = 5; // Oletusäänenvoimakkuus
        taajuus = 88.0;      // Oletustaajuus
    }

    // Metodi radion kytkemiseksi pois päältä
    public void KytkePoisPaalta()
    {
        paalla = false;
        Console.WriteLine("Radio on pois päältä.");
    }

    // Metodi radion kytkemiseksi päälle
    public void KytkePaalle()
    {
        paalla = true;
        Console.WriteLine("Radio on päällä.");
    }

    // Metodi äänenvoimakkuuden säätämiseksi
    public void Aanenvoimakkuus(int uusiAanenvoimakkuus)
    {
        if (uusiAanenvoimakkuus >= 0 && uusiAanenvoimakkuus <= 9)
        {
            aanenvoimakkuus = uusiAanenvoimakkuus;
            Console.WriteLine($"Äänenvoimakkuus: {aanenvoimakkuus}");
        }
        else
        {
            Console.WriteLine("Virheellinen äänenvoimakkuusarvo.");
        }
    }

    // Metodi taajuuden säätämiseksi
    public void Taajuus(double uusiTaajuus)
    {
        if (uusiTaajuus >= 88.0 && uusiTaajuus <= 107.9)
        {
            taajuus = uusiTaajuus;
            Console.WriteLine($"Valittu taajuus: {taajuus}");
        }
        else
        {
            Console.WriteLine("Virheellinen taajuusarvo.");
        }
    }

    // Metodi tulostamaan radion tiedot
    public void Tiedot()
    {
        Console.WriteLine($"Radio on {(paalla ? "päällä" : "pois päältä")}, Äänenvoimakkuus: {aanenvoimakkuus}, Taajuus: {taajuus}");
    }
}

class Ohjelma
{
    static void Main()
    {
        // Luodaan radio-olio
        Radio radio = new Radio();

       
        while (true)
        {
            // Tulostetaan valikko
            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("1 - Kytke radio päälle");
            Console.WriteLine("2 - Kytke radio pois päältä");
            Console.WriteLine("3 - Säädä äänenvoimakkuutta");
            Console.WriteLine("4 - Valitse taajuus");
            Console.WriteLine("5 - Tulosta radio-olion tiedot");
            Console.WriteLine("0 - Lopeta");

            // Lue käyttäjän syöte
            int valinta = Convert.ToInt32(Console.ReadLine());

            // Käsittele valinta
            switch (valinta)
            {
                case 1:
                    radio.KytkePaalle();
                    break;

                case 2:
                    radio.KytkePoisPaalta();
                    break;

                case 3:
                    Console.WriteLine("Anna uusi äänenvoimakkuus (0-9):");
                    int aanenvoimakkuus = Convert.ToInt32(Console.ReadLine());
                    radio.Aanenvoimakkuus(aanenvoimakkuus);
                    break;

                case 4:
                    Console.WriteLine("Anna uusi taajuus (88.0-107.9):");
                    double taajuus = Convert.ToDouble(Console.ReadLine());
                    radio.Taajuus(taajuus);
                    break;

                case 5:
                    radio.Tiedot();
                    break;

                case 0:
                    // Lopeta ohjelma
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Virheellinen valinta.");
                    break;
            }

            Console.WriteLine();
        }
    }
}