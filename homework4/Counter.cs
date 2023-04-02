namespace homework4;
class Counter
{
    public delegate void Container(int num);
    public event Container OnCount;
    
    public void Count()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i == 69)
            {
                OnCount(i);
            }
        }
    }
}
