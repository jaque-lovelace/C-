using System;

namespace semaforo
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            //int verde, amarelo,vermelho;
            Console.WriteLine("Escolha uma cor: (1- verde, 2 - amarelo, 3 - vermelho)");
            op = int.Parse(Console.ReadLine());

            switch (op){
                case 1 :
                Console.WriteLine("Siga em Frente!");
                break;

                case 2 :
                Console.WriteLine("Atenção!");
                break;

                case 3 : 
                Console.WriteLine("Pare!");
                break;

                default:
                Console.WriteLine("Opção inválida");
                break;
            
                
            
            }
        }
    }
}
