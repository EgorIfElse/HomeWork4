internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите сторону прямоугольника А");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите сторону прямоугольника B");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите сторону квадрата C");
        int c = Convert.ToInt32(Console.ReadLine());
        int s = c;
        int d = c;
        int i = 0;

        while (b >= s)
        {
            d = c;

            while (a >= d)
            {
               
                d += c;
                i++;
            }
            s  += c;
            
        }
        int p = i % 100;


        if (19 >= p && p >= 11)
        {
            Console.WriteLine("В такой прямоугольник поместится {0} квадратов", i);

        }
        else
        {

            switch (i % 10)
            {

                case 1:
                    Console.WriteLine("В такой прямоугольник поместится {0} квадрат", i);
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("В такой прямоугольник поместится {0} квадрата", i);
                    break;
                default:
                    Console.WriteLine("В такой прямоугольник поместится {0} квадратов", i);
                    break;

            }
        }


        







    }
}