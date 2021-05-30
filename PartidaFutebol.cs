using System;

namespace partidaFutebol
{
    class Program
    {
        static void Main(string[] args)
        {
            string time01, time02;
            int golTime01,golTime02;
            Console.WriteLine("Entre com o nome do primeiro time: ");
            time01 = Console.ReadLine();
            Console.WriteLine("Entre com o número de gols do Time 01:");
            golTime01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome do segundo time: ");
            time02 = Console.ReadLine();
            Console.WriteLine("Entre com o número de gols do Time 02");
            golTime02 = int.Parse(Console.ReadLine());
            
            if (golTime01>golTime02)
            {
                Console.WriteLine( time01 + " é o vencedor!!");
                
                
            }
            if (golTime01<golTime02)
            {
                Console.WriteLine(time02 + " é o vencedor!!!");
            }
                
            else
            {
             
                Console.WriteLine("Empate!!!");   
            }        
        }
    }
}
