namespace homework3;

public class Patient : Human
{
    public bool Status { get; set; }

    public Patient(string n, int a) : base(n, a) { }

    public void KnockOnTheDoor(Doctor d)
    {
        Console.WriteLine("*стук в дверь*");

        this.Say($"{d.Name}, можно войти?");
    }
}
