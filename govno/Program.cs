using System;

namespace govno;
class Program
{
    public static int Input_int(string x)
    {
        bool flag;
        int result;
        do
        {
            Console.Write($"{x} = ");
            if (!int.TryParse(Console.ReadLine(), out result))
            {
                flag = false;
                Console.WriteLine("некорректный ввод, повторите попытку");
            }
            else
            {
                if (result <= 0)
                {
                    Console.WriteLine("условие не выполнено, повторите ввод");
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
        }
        while (!flag);
        return result;
    }
    public static double Input_double(string x)
    {
        bool flag;
        double result;
        do
        {
            Console.Write($"{x} = ");
            if (!double.TryParse(Console.ReadLine(), out result))
            {
                flag = false;
                Console.WriteLine("некорректный ввод, повторите попытку");
            }
            else
            {
                if (result <= 0)
                {
                    Console.WriteLine("условие не выполнено, повторите ввод");
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
        }
        while (!flag);
        return result;
    }
    public static double Function1(double x, double z)
    {
        double f1 = x * Math.Atan(x / Math.Sqrt(z)) - Math.Log(Math.Pow(x * x + z, 1.0 / 3)) + 1;
        return f1;
    }
    public static double Function2(double x, double z)
    {
        double f2 = Math.Pow(Math.E, Math.Sqrt(z)) + Math.Pow(x, 4.0 / 3) * (1 + (x - z / x) / x + z / x) * Math.Abs(Math.Sin(x));
        return f2;
    }
    static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            int m, n;
            double x, z, dx, dz, f1, f2;
            x = Input_double("x");
            z = Input_double("z");
            dx = Input_double("dx");
            dz = Input_double("dz");
            m = Input_int("m");
            n = Input_int("n");
            Console.WriteLine("Нажмите Х, чтобы посмотреть результат первой функции, или У, чтобы посмотреть результат второй функции. Если хотите посмотреть результат двух функций, нажмите любую другую клавишу");
            var q = Console.ReadKey().Key;
            for (int i = 0; i < n; i++, x += dx)
            {
                for (int j = 0; j < m; j++, z += dz)
                {
                    if (q == ConsoleKey.X)
                    {
                        Console.WriteLine();
                        f1 = Function1(x, z);
                        Console.WriteLine($"при N = {i} и M = {j} f1 = {f1}");
                    }
                    else if (q == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        f2 = Function2(x, z);
                        Console.WriteLine($"при N = {i} и M = {j} f2 = {f2}");
                    }
                    else
                    {
                        Console.WriteLine();
                        f1 = Function1(x, z);
                        f2 = Function2(x, z);
                        Console.WriteLine($"при N = {i} и M = {j} f1 = {f1}");
                        Console.WriteLine($"при N = {i} и M = {j} f2 = {f2}");
                    }
                }
            }
            Console.WriteLine("Нажмите escape, чтобы завершить программу, или любую другую клавишу, чтобы перезапустить её");
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}

