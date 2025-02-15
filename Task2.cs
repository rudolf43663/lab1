using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число x: ");
        string x = Console.ReadLine();
        char secondNum = x[1];
        string n = x.Remove(1, 1) + secondNum;
        Console.WriteLine("n = " + n);
    }
}
