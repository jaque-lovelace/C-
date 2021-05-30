using System;

namespace areaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;
            Console.WriteLine("Digite o raio do círculo");
            raio = double.Parse(Console.ReadLine());
            area = 3.14 * Math.Pow(raio, 2);
            Console.WriteLine("A área do círculo é: " + area);
        }
    }
}
