using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        int result = 1;
		
        for (int index = 0; index < n; ++index)
        {
            result *= a;
        }

        Console.WriteLine(a + "^" + n + " = " + result);
    }
}
