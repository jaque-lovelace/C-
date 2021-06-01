using System;

namespace escolha
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 5;
            do
            {

                float num1, num2, resultado = 0;
                Console.WriteLine(" Informe o primeiro número: ");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine(" Informe o segundo número: ");
                num2 = float.Parse(Console.ReadLine());
                Console.WriteLine(" Informe a operação desejada (1 - Adição 2- Subtração 3 - Multiplicação 4- Divisão ou 0 para sair)");

                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    resultado = num1 + num2;
                    Console.Write("O resultado da adição é: {0:N}", resultado);

                }
                else
                {
                    switch (op)
                    {
                        case 2:
                            resultado = num1 - num2;
                            Console.Write("O resultado da subtração é: {0:N}", resultado);

                            break;
                        case 3:
                            resultado = num1 * num2;
                            Console.WriteLine("O resultado da multiplicação é: {0:N}", resultado);

                            break;
                        default:
                            switch (op)
                            {
                                case 4:
                                    resultado = num1 / num2;
                                    Console.WriteLine("O resultado da divisão é {0:N}", resultado);


                                    break;
                                default:
                                    break;
                            }
                            break;
                    }

                }
            } while (op != 0);
        }
    }
}
