﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число больше 0");
        int n = Convert.ToInt32(Console.ReadLine());

        int s = 0;

        for (int i = 1; i <= n; i++)
        {
           
            s += 2*i -1;
            Console.WriteLine("Квадрат числа {0} равен {1}", i, s);

        }
    }
}