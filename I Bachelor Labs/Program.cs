using System.Text;

namespace I_Bachelor_Labs;

class RunField
{
    public static void Main(string[] args)
    {
        do
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write( "1: Лабораторна 3, завдання 1 - Обчислення функції" +'\n' +
                              "2: Лабораторна 3, завдання 2 - Обчислення периметра і площі" +'\n' +
                              "3: Лабораторна 3, завдання 3 - Обчислення функції, з декількома інпутами" + '\n' +
                              "4: Лабораторна 4, завдання 1 - Виведення чисел Мерсена, що менші за інпут");
            ConsoleKey keypressed1;
            ConsoleKeyInfo keyInfok = Console.ReadKey(true);
            if (Int32.TryParse(keyInfok.KeyChar.ToString(), out _))
            {
                keypressed1 = keyInfok.Key;
            }
            else keypressed1 = ConsoleKey.F24;

            switch (keypressed1)
            {
                case ConsoleKey.D1:
                    try
                    {
                        Console.WriteLine();
                        Console.Write("Введіть х: ");
                        Console.WriteLine("Результат функції: " +
                                          Lab3.Task1(double.Parse(Console.ReadLine() ?? string.Empty)));
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Невірний інпут");
                        throw;
                    }

                case ConsoleKey.D2:
                    double perimetre;
                    double area;
                    Console.WriteLine();
                    try
                    {
                        Console.Write("Введіть сторону квадрата: ");
                        Lab3.Task2(double.Parse(Console.ReadLine()), out perimetre, out area);
                        Console.WriteLine("Периметр: " + perimetre);
                        Console.WriteLine("Площа: " + area);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Невірний інпут");
                        throw;
                    }
                case ConsoleKey.D3:
                    try
                    {
                        Console.WriteLine();
                        Console.Write("Введіть х: ");
                        double x = double.Parse(Console.ReadLine()), b, c;
                        Console.Write("Введіть b: ");
                        b = double.Parse(Console.ReadLine());
                        Console.Write("Введіть c: ");
                        c = double.Parse(Console.ReadLine());
                        if (double.IsNaN(Lab3.Task3(x, b, c)))
                        {
                            break;
                        }

                        Console.WriteLine("Результат функції: " + Lab3.Task3(x, b, c));
                        break;
                    }
                    
                    catch (FormatException)
                    {
                        Console.WriteLine("Невірний інпут");
                        throw;
                    }
                case ConsoleKey.D4:
                    try
                    {
                        Console.WriteLine();
                        Console.Write("Введіть n: ");
                        int input = int.Parse(Console.ReadLine());
                        Lab4.Mersenne(input);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Невірний інпут");
                        throw;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Число завелике, можливі значення від 1 до 2147483647");
                        throw;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                    break;
            }
        } while (Console.ReadLine()?.ToLower() != "вийти");
    }
}
   