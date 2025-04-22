using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Bok> bibliotek = new List<Bok>();

    static void Main()
    {
        bibliotek.Add(new Roman("12345", "Hobbiten", "J.R.R. Tolkien", 1937, "Fantasy"));
        bibliotek.Add(new Fagbok("67890", "C# for Nybegynnere", "John Doe", 2020, "Programmering"));

        bool kjører = true;
        while (kjører)
        {
            Console.WriteLine("\nBibliotek meny:");
            Console.WriteLine("1. Legg til bok");
            Console.WriteLine("2. Liste opp alle bøker");
            Console.WriteLine("3. Søk etter forfatter");
            Console.WriteLine("4. Søk etter bøker etter årstall");
            Console.WriteLine("5. Finn bok etter tittel");
            Console.WriteLine("6. Avslutt");

            Console.Write("Velg et alternativ: ");
            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    LeggTilBok();
                    break;
                case "2":
                    ListeOppBøker();
                    break;
                case "3":
                    SøkEtterForfatter();
                    break;
                case "4":
                    SøkEtterÅrstall();
                    break;
                case "5":
                    FinnBokEtterTittel();
                    break;
                case "6":
                    kjører = false;
                    break;
                default:
                    Console.WriteLine("Ugyldig valg, prøv igjen.");
                    break;
            }
        }
    }

    static void LeggTilBok()
    {
        Console.Write("Tittel: ");
        string tittel = Console.ReadLine();

        Console.Write("Forfatter: ");
        string forfatter = Console.ReadLine();

        Console.Write("Utgivelsesår: ");
        int år = int.Parse(Console.ReadLine());

        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();

        Console.Write("Type (1: Roman, 2: Fagbok): ");
        string type = Console.ReadLine();

        if (type == "1")
        {
            Console.Write("Sjanger: ");
            string sjanger = Console.ReadLine();
            bibliotek.Add(new Roman(isbn, tittel, forfatter, år, sjanger));
        }
        else if (type == "2")
        {
            Console.Write("Fagområde: ");
            string fagområde = Console.ReadLine();
            bibliotek.Add(new Fagbok(isbn, tittel, forfatter, år, fagområde));
        }
        Console.WriteLine("Bok lagt til!");
    }

    static void ListeOppBøker()
    {
        Console.WriteLine("\nAlle bøker:");
        foreach (var bok in bibliotek)
        {
            bok.VisInfo();
        }
    }

    static void SøkEtterForfatter()
    {
        Console.Write("Forfatter: ");
        string forfatter = Console.ReadLine();

        var bøker = bibliotek.Where(b => b.Forfatter.ToLower().Contains(forfatter.ToLower()));

        foreach (var bok in bøker)
        {
            bok.VisInfo();
        }
    }

    static void SøkEtterÅrstall()
    {
        Console.Write("Søk etter bøker utgitt etter år: ");
        int år = int.Parse(Console.ReadLine());

        var bøker = bibliotek.Where(b => b.Utgivelsesår > år);

        foreach (var bok in bøker)
        {
            bok.VisInfo();
        }
    }

    static void FinnBokEtterTittel()
    {
        Console.Write("Tittel: ");
        string tittel = Console.ReadLine();

        var bok = bibliotek.FirstOrDefault(b => b.Tittel.ToLower() == tittel.ToLower());

        if (bok != null)
            bok.VisInfo();
        else
            Console.WriteLine("Boken ble ikke funnet.");
    }
}


// // // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");

// // // Opprette et objekt "Christian" av Type "Person" ved bruk av nøkkelord "new" og konstruktøren "Person()"
// // Person Christian = new Person();

// // //Sette verdi til "navn" som er automatisk implementert egenskap
// // Christian.Navn = "Christian";

// // //Kaller "Spise()" og "kjøpe" metodene på "Christian" objektet
// // Christian.Spise();
// // Christian.Kjøpe();

// // /* Laget metode slik at man kan bestille mat ved valg av enten 
// // pizza, salat eller hamburger
// //  ved hjelp av switch/case funksjon */


// // Christian.Bestille("hamburgr");


// //Innlevering 1. til 28.2.2025
// class Program
// {
//     static void Main(string[] args)
//     {
//         Handlekurv handlekurv = new Handlekurv();

//         Console.WriteLine("Hvor mange varer vil du legge til i handlekurven?");
//         int antallVarer = int.Parse(Console.ReadLine() ?? "0");

//         for (int i = 0; i < antallVarer; i++)
//         {
//             Console.WriteLine($"Skriv inn prisen for vare {i + 1}:");
//             double pris = double.Parse(Console.ReadLine() ?? "0");
//             handlekurv.LeggTilVare(pris);
//         }

//         double totalpris = handlekurv.BeregnTotal();
//         handlekurv.SkrivKvittering();

//         if (totalpris > 500)
//         {
//             Console.WriteLine("Gratulerer! Du kvalifiserer for gratis frakt.");
//         }
//     }
// }