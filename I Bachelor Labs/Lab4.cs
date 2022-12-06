namespace I_Bachelor_Labs;

public class Lab4
{
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
                return false;
        }
        return true;        
    }

    public static void Mersenne(int n)
    {
        if (n < 0)
        {
            Console.WriteLine("Введене число не є натуральним");
        }
        else if (n == 0 || n == 1 || n == 2)
        {
            Console.WriteLine($"Нема жодного простого числа Мерсенна, що менші за {n}");
        }
        else
        {
            for (int i = 1; Math.Pow(2, i) - 1 <= n; i++)
            {
                if (IsPrime(i))
                {
                    if (Math.Pow(2, i) - 1 < n)
                    {
                        Console.WriteLine($"Число Мерсенна, що менше за {n}: {Math.Pow(2, i) - 1}");
                    }
                }
            }
        }
    }
}