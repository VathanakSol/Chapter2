using System;
namespace Chapter2;
class Program
{
    static void Main(String[] args)
    {
        Console.Clear();
        string st = "34";
        double a = double.Parse(st);
        Console.WriteLine(a);
       
        Console.WriteLine("a: {0}", a);
        Console.WriteLine($"a: {a}");

        int n = int.Parse(st);
        int m = Convert.ToInt32(st);
        Console.WriteLine(n);
        Console.WriteLine(m);


        Console.ReadKey();
    }
}