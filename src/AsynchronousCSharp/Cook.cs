namespace AsynchronousCSharp;

// https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/

public class Cook
{
    public Cook()
    {
        PourCoffee();
        FryEggs();
        FryBacon();
        ToastBread();
        AddButterAndJam();
        PourOrangeJuice();
    }
    
    public void PourCoffee()
    {
        Console.WriteLine("Pour Coffee!!");
    }

    public void FryEggs()
    {
        Console.WriteLine("Fried Eggs!!");
    }

    public void FryBacon()
    {
        Console.WriteLine("Fried Bacon!!");
    }

    public void ToastBread()
    {
        Console.WriteLine("Toasted bread!!");
    }

    public void AddButterAndJam()
    {
        Console.WriteLine("Added butter and Jam!!");
    }

    public void PourOrangeJuice()
    {
        Console.WriteLine("Pour Orange Juice");
    }
}
