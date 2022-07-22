using System;

namespace DaireProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ConsoleColor borderColor=ConsoleColor.Red;
            Console.ForegroundColor=borderColor;
            Console.Write("Lütfen Yarıçap giriniz : ");
            double r =double.Parse(Console.ReadLine());
            Daire(r);
        }
        static double Daire(double r)
        {
            double thickness = 0.2;
            Console.WriteLine();
            double rIn=r -thickness,rOut =r + thickness;
             for (double y = r; y >= -r; --y)
            {
                for (double x = -r; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");

                    }
                    else{
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            return 0;
        }
    }
}