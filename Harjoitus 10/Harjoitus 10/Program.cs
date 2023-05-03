using Harjoitus_10;

internal class Program
{
    static void Main(string[] args)
    {
        Varis varis = new Varis("Varis", 90);

        varis.TeeÄäni();
        varis.Lento();

        Kala ahven = new Kala("Ahven", 50, "Blup");

        ahven.TeeÄäni();
        ahven.Uinti();

        Sorsa sorsa = new Sorsa("Sorsa", 90, 20);

        sorsa.TeeÄäni();
        sorsa.Lento();
        sorsa.TeeÄäni();
        sorsa.Uinti();
    }
}