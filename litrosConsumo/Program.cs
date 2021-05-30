using System;

namespace litrosConsumo
{
    class Program
    {
        static void Main(string[] args)
        {
            float distancia, consumo;
            Console.WriteLine("Digite a distância a ser percorrida em km: ");
            distancia = float.Parse(Console.ReadLine());
            consumo = distancia / 12;
            Console.WriteLine("O consumo em Litros será de: " + consumo + "litros");
        }
    }
}
