using System.Reflection.Metadata.Ecma335;


//konstruktør
public class Bil
{
    // Class members go here
    public string Model { get; set; }
    public int Year { get; set; }

    public Bil(string model, int year)
    {
        Model = model;
        Year = year;
    }

    public void Drive()
    {
        Console.WriteLine($"{Model} from {Year} is driving.");
    }
}

