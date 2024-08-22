internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите последовательность чисел. '0' остановка ввода");
        int plus = 0;
        int minus = 0;
        int N = 0;
        do
        {
            N = Convert.ToInt32(Console.ReadLine());
            
            if (N > 0)
            {
                plus++;  
            }
            else
            {
                minus++;

            }
            
        }while (N != 0);

        if (plus > (minus - 1))
        {
            Console.WriteLine("Положительных больше");
        }
        else
        {
            Console.WriteLine("Отрицательных больше");
        }

    }
}