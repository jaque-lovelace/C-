using System;

namespace assistenteTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um código que pergunte quanto você tem para a passagem. Se esse valor for menor do que R$ 10,00, imprima “Vá de ônibus”. Se o valor for menor do que R$ 50,00, imprima “Vá de táxi”. Se o valor for menor do que R$ 150,00, imprima “Vá de avião”. Se o valor for menor do que R$ 500,00, imprima “Vá de helicóptero”. Se o valor for superior a R$ 500,00, imprima “Vá de navio”



            double quanto;
            Console.WriteLine("Quanto dinheiro você tem? R$  ");
            quanto = double.Parse(Console.ReadLine());

            if (quanto < 10f)
            {
                Console.WriteLine("Vá de ônibus!");
            }
            else
            {
                if (quanto < 50f)
                {
                    Console.WriteLine("Vá de taxi");
                }
                else
                {
                    if (quanto < 150f)
                    {
                        Console.WriteLine("Vá de avião");
                    }
                    else
                    {
                        if (quanto < 500f)
                        {
                            Console.WriteLine("Vá de Helicóptero");
                        }
                        else
                        {
                            if (quanto > 500f)
                            {
                                Console.WriteLine("Vá de navio");
                            }
                        }
                    }
                }
            }
        }
    }
}
