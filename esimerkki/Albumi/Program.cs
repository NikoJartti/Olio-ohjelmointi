using harjoitus_4;

internal class Program
{
    private static void Main(string[] args)
    {
        Albumi albumi = new Albumi("Imagine Dragons", "Evolve", "Pop-rock", 10);

        albumi.LisääKappale(new Kappale("Next To Me", "3:50"));
        albumi.LisääKappale(new Kappale("I Don´t Know Why", "3:10"));

        albumi.TulostaAlbumi();
    }
}