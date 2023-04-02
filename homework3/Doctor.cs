namespace homework3;

public class Doctor : Human
{
    public int Experience { get; set; }

    public Doctor(string n, int a, int s) : base(n, a)
    {
        Experience = s;
    }

    public void Cure(Patient p)
    {
        Random rand = new Random();

        p.Status = rand.Next(100) < 50;

        Console.WriteLine("A few moments later...");

        if (p.Status)
        {
            Console.WriteLine($"{this.Name} вылечил {p.Name}");
        }
        else
        {
            Console.WriteLine($"{Name} назначил лечение {p.Name} и записал на повторный прием");
        }
    }

    public bool IsFreedom()
    {
        Random rand = new Random();

        return rand.Next(100) < 50;
    }
}
