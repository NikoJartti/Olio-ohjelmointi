using System;

// Abstrakti luokka, joka edustaa yleistä henkilöä
abstract class Henkilo
{
    // Ominaisuudet, jotka kuvaavat henkilöä
    public string Nimi { get; set; }
    public string Tyopaikka { get; set; }
    public decimal Palkka { get; set; }

    // Konstruktori alustaa henkilön ominaisuudet
    public Henkilo(string nimi, string tyopaikka, decimal palkka)
    {
        Nimi = nimi;
        Tyopaikka = tyopaikka;
        Palkka = palkka;
    }

    // Abstrakti metodi, joka vaatii kaikkia aliluokkia toteuttamaan sen
    public abstract void TulostaTiedot();
}

// Työntekijä-luokka perii Henkilo-luokan
class Tyontekija : Henkilo
{
    // Uusi ominaisuus, joka kuvailee työntekijän viikottaisia työtunteja
    public int ViikottaisetTunnit { get; set; }

    // Työntekijä-luokan konstruktori kutsuu yläluokan konstruktoria
    public Tyontekija(string nimi, string tyopaikka, decimal palkka, int viikottaisetTunnit)
        : base(nimi, tyopaikka, palkka)
    {
        ViikottaisetTunnit = viikottaisetTunnit;
    }

    // Ylikirjoitettu metodi tulostaa työntekijän tiedot
    public override void TulostaTiedot()
    {
        Console.WriteLine($"Työntekijä: {Nimi}, Työpaikka: {Tyopaikka}, Palkka: {Palkka}, Viikottaiset tunnit: {ViikottaisetTunnit}");
    }
}

class Pomo : Henkilo
{
    // Uudet ominaisuudet, jotka kuvaavat pomon bonusta ja autoa
    public decimal Boonus { get; set; }
    public string Auto { get; set; }

    // Pomo-luokan konstruktori kutsuu yläluokan konstruktoria
    public Pomo(string nimi, string tyopaikka, decimal palkka, decimal boonus, string auto)
        : base(nimi, tyopaikka, palkka)
    {
        Boonus = boonus;
        Auto = auto;
    }

    // Ylikirjoitettu metodi tulostaa pomon tiedot
    public override void TulostaTiedot()
    {
        Console.WriteLine($"Pomo: {Nimi}, Työpaikka: {Tyopaikka}, Palkka: {Palkka}, Boonus: {Boonus}, Auto: {Auto}");
    }
}

// Ohjelma-luokka sisältää Main-metodin, joka toimii ohjelman pääsilmukkana
class Ohjelma
{
    static void Main()
    {
        // Luodaan työntekijä ja pomo
        Tyontekija tyontekija = new Tyontekija("Olli", "Yritys", 2500, 30);
        Pomo pomo = new Pomo("Kari", "Yritys", 4000, 500, "BMW");

        // Kutsutaan Tyontekija- ja Pomo-luokkien TulostaTiedot-metodeita
        tyontekija.TulostaTiedot();
        pomo.TulostaTiedot();
    }
}