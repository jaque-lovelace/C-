using System;

namespace areaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float b, h,area; //entrada de dados
            Console.WriteLine("Qual a base do triângulo? ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a altura do triângulo? ");
            h = float.Parse(Console.ReadLine());
            area = (b * h)/2f;
            Console.WriteLine("A área do triângulo é {0:N} metros quadrados" , area);



        }
    }
}
