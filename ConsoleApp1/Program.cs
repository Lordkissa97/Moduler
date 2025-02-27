// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // Opprette et objekt "Christian" av Type "Person" ved bruk av nøkkelord "new" og konstruktøren "Person()"
// Person Christian = new Person();

// //Sette verdi til "navn" som er automatisk implementert egenskap
// Christian.Navn = "Christian";

// //Kaller "Spise()" og "kjøpe" metodene på "Christian" objektet
// Christian.Spise();
// Christian.Kjøpe();

// /* Laget metode slik at man kan bestille mat ved valg av enten 
// pizza, salat eller hamburger
//  ved hjelp av switch/case funksjon */


// Christian.Bestille("hamburgr");


//Innlevering 1. til 28.2.2025
class Program
{
    static void Main(string[] args)
    {
        Handlekurv handlekurv = new Handlekurv();

        Console.WriteLine("Hvor mange varer vil du legge til i handlekurven?");
        int antallVarer = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < antallVarer; i++)
        {
            Console.WriteLine($"Skriv inn prisen for vare {i + 1}:");
            double pris = double.Parse(Console.ReadLine() ?? "0");
            handlekurv.LeggTilVare(pris);
        }

        double totalpris = handlekurv.BeregnTotal();
        handlekurv.SkrivKvittering();

        if (totalpris > 500)
        {
            Console.WriteLine("Gratulerer! Du kvalifiserer for gratis frakt.");
        }
    }
}