namespace семинар_какой_то_там;
class Program
{
    public static double[] AddArrey(double[] a)
    {
        Random rnd = new Random();
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.NextDouble() * 25 - 12.5;
        }
        return a;
    }
    public static void OutputArrey(double[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        double[] a = new double[10];
        a = AddArrey(a);
        OutputArrey(a);
        Console.ReadLine();
    }
}

