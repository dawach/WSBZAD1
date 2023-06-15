using System;

namespace testyzad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartości a, b, c równania kwadratowego:");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            int liczbaPierwiastkow = ObliczaniePierwiastkow(a, b, c);

            Console.WriteLine($"Liczba pierwiastków: {liczbaPierwiastkow}");
        }

        public static int ObliczaniePierwiastkow(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                return 0;
            }
            else if (delta == 0)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
