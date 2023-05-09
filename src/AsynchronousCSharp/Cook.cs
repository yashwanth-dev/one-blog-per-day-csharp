namespace AsynchronousCSharp;

// https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/

public class Cook
{
    public async Task PrepareBreakfast()
    {
        PourCoffee();
        var eggsTask = FryEggs();
        var eggs = await eggsTask;
        var baconTask = FryBacon();
        var bacon = await baconTask;
        var toastTask = ToastBread();
        var toast = await toastTask;
        AddButterAndJam();
        PourOrangeJuice();
    }
    
    public void PourCoffee()
    {
        Console.WriteLine("Pour Coffee!!");
    }

    public async Task<string> FryEggs()
    {
        Console.WriteLine("Fried Eggs!!");
        return "Eggs";
    }

    public async Task<string> FryBacon()
    {
        Console.WriteLine("Fried Bacon!!");
        return "Bacon";
    }

    public async Task<string> ToastBread()
    {
        Console.WriteLine("Toasted bread!!");
        AddButterAndJam();
        return "Toast";
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
