using System.Collections;

public class Person {
    //instans variabler og de er synlige kun for metodene i "person" klassen
    private string navn;
    private string handleliste;

    //Leke med C# sine automatisk implementerte egenskaper
    public string Navn {get; set;}

/*
Konstruktøren får alltid samme anvn som klassens navn,
men med metode paranteser "Person()" for å kunne opprette objekter
av type Person
*/
public Person() {
    //Initialisere verdiene til navn og handleliste
    navn = "";
    handleliste = "";
    Navn = "";
}

//Metoder
public void Spise() {
    // "mat" er en lokal variabel og den er synlig kun for "Spise()" metoden
    string mat = "kjøtt";
    Console.WriteLine($"Hei {Navn}! Du spiser nå "+ mat);
}

public void Kjøpe() {
    handleliste = "egg, melk, ost, brød";
    Console.WriteLine("Din vanlige handleliste er: "+ handleliste);

    /* Hvis du prøver å bruke "mat" variabelen i "Kjøpe()" metoden så får du kjeft fra C# kompilatoren at den variabelen
    ikke finnes i konteksten av denne metoden "Kjøpe".
    Den følgende linjen vil da ikke kjøres:
    Console.WriteLine("Din valinge handleliste er: "+ mat);
    */

}

/* bestille mat pizza, salat eller hamburger*/
public void Bestille(string item) {
    string bestilling = "";

switch (item)
{
    case "pizza":
        bestilling = $"{Navn} bestiller en hvit pizza, med spekeskinke, mozarella og oregano.";
        break;
    case "salat":
        bestilling = $"{Navn} bestiller en Cæsarsalat med olvenolje ved siden av.";
        break;
    case "hamburger":
        bestilling = $"{Navn} bestiller en dobbel cheeseburger med pommesfrites som tilbehør.";
        break;
    default:
        Console.WriteLine($"{Navn} gjør ett ugyldig valg. Velg mellom pizza, salat eller hamburger.");
        return;
}

    Console.WriteLine(bestilling);
}}