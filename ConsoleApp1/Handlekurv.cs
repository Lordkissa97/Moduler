
class Handlekurv
{
    private List<double> varePriser;
    private double totalpris;
    private int antallVarer;

    public Handlekurv()
    {
        varePriser = new List<double>();
        totalpris = 0.0;
        antallVarer = 0;
    }

    public void LeggTilVare(double pris)
    {
        varePriser.Add(pris);
        totalpris += pris;
        antallVarer++;
    }

    public double BeregnTotal()
    {
        return totalpris;
    }

    public void SkrivKvittering()
    {
        Console.WriteLine("Kvittering:");
        for (int i = 0; i < varePriser.Count; i++)
        {
            Console.WriteLine($"Vare {i + 1}: {varePriser[i]:C}");
        }
        Console.WriteLine($"Totalt antall varer: {antallVarer}");
        Console.WriteLine($"Totalpris: {totalpris:C}");
    }
}