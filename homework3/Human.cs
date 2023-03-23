namespace homework3;

public class Human
{
    public string Name { get; }
    public int Age { get; }
    
    public Human(string n, int a)
    {
        Name = n;
        Age = a;
    }

    public void Say(string text)
    {
        Console.WriteLine($"{Name} говорит: '{text}'");
    }
}
