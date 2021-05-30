using System;

namespace antecessorSucessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1,numero2;
            Console.WriteLine("Entre com o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());
            
            if(numero1>numero2)
                Console.WriteLine (numero2 + "|" + numero1);
            if(numero1<numero2)
                Console.WriteLine(numero1 + "|" + numero2);

        }
    }
}
