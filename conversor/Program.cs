using System;

namespace conversor
{
    class Program
    {
        static void Main(string[] args)
        {

            float tc, tf;// declaração das variáveis de tc e tf
            Console.WriteLine("Informe a temperatura em Ceslius: ");
            tc=float.Parse(Console.ReadLine());//leitura (entrada de dados ) temperatura em celsius
            tf =(tc * 1.8f) + 32f; //fórmula para o cáculo de conversão de temperatura
            Console.WriteLine("A temperatura em Fahrenheit é {0:N}°F", tf); //mostra na tela 
        }
    }
}
