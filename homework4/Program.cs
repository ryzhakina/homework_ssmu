namespace homework4;

class Program
{
    static void Main(string[] args)
    {
        Counter counter = new Counter();
        FirstHandler handler1 = new FirstHandler();
        SecondHandler handler2 = new SecondHandler();

        counter.OnCount += handler1.Message;
        counter.OnCount += handler2.Message;

        counter.Count();
    }
}
