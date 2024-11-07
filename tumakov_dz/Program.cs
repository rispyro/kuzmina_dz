using System;
class Hello
{
    public static void Main()
    {
        Console.WriteLine("lab 2.1");
        Console.Write("enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine("\nlab 2.2");
        int num, num1;
        Console.WriteLine("enter first num:");
        num = Convert.ToInt32(Console.ReadLine()); //переводим к целочисленному типу
        Console.WriteLine("enter second num:");
        num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 == 0)
        {
            Console.WriteLine("an impossible action");
        }
        else
        {
            Console.WriteLine("the result:" + (num / num1));
        }
        Console.WriteLine("\ndz 2.1");
        Console.WriteLine("------");

        Console.WriteLine("\ndz 2.2");
        int a1, b1, c1, xx, d;
        double xx1, xx2;
        Console.Write("enter a: ");
        a1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter b: ");
        b1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter c: ");
        c1 = Convert.ToInt32(Console.ReadLine());
        d = (b1 * b1) - (4 * c1 * a1);
        if (d < 0)
        {
            Console.WriteLine("no roots:(");
        }
        else
        {
            if (d > 0)
            {
                xx1 = (-b1 + (Math.Sqrt(d))) / (2 * a1);
                xx2 = (-b1 - (Math.Sqrt(d))) / (2 * a1);
                Console.WriteLine($"roots:{xx1},{xx2}");
            }
            else
            {
                xx = -b1 / 2 * a1;
                Console.WriteLine($"the only root: {xx}");
            }
        }
    }
}