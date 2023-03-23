using System;

int count = 0;
while (count <= 0)
{
    Console.Write("Введи размер массива: ");

    if (!int.TryParse(Console.ReadLine(), out count))
    {
        Console.WriteLine($"Необходимо ввести число");
    }
    else if (count < 0)
    {
        Console.WriteLine($"Необходимо ввести положительное число");
    }
    else if (count == 0)
    {
        Console.WriteLine($"Число не может быть равное нулю");
    }
}

int max = 0;
int premax = 0;

int[] nums = new int[count];
for (int i = 0; i < count; i++)
{
    while (true)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");

        if (int.TryParse(Console.ReadLine(), out nums[i]))
        {
            break;
        }

        Console.WriteLine($"Необходимо ввести число");
    }

    if (nums[i] > premax)
    {
        premax = nums[i];
    }

    if (nums[i] > max)
    {
        premax = max;
        max = nums[i];
    }
}

Console.WriteLine($"Второй наибольший элемент: {premax}");