using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string A, B, C;
            double Lado1 , Lado2, Lado3, SemiPerimetro , Area;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("_______________________________________");
            Console.WriteLine(""); 

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Digite os lados do triângulo desejado.");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("_______________________________________");
            Console.WriteLine(""); 

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Lado 1..: ");

            Console.ForegroundColor = ConsoleColor.White;
            A = Console.ReadLine(); 

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Lado 2..: ");

            Console.ForegroundColor = ConsoleColor.White;
            B = Console.ReadLine();
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Lado 3..: ");

            Console.ForegroundColor = ConsoleColor.White;
            C = Console.ReadLine();
            Console.WriteLine("");

            Lado1 = Convert.ToDouble(A);
            Lado2 = Convert.ToDouble(B);
            Lado3 = Convert.ToDouble(C);

            SemiPerimetro = (Lado1 + Lado2 + Lado3) /2;

            Area = Math.Sqrt (SemiPerimetro * (SemiPerimetro - Lado1) * (SemiPerimetro - Lado2) * (SemiPerimetro - Lado3));
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Semiperímetro..: "); 

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{SemiPerimetro}\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Área...........: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{Area}");

            Console.ResetColor();
        }
    }
}