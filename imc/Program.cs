using System;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome,continua, situacao = "";
            double peso, altura, imc;



            do
            {
                Console.WriteLine("Entre com o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Entre com o peso: ");
                peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Entre com a altura: ");
                altura = double.Parse(Console.ReadLine());

                imc = peso / (altura * altura);
                //Console.WriteLine("O IMC é:" + imc);


                if (imc <= 20)
                {
                    situacao = " abaixo do peso!";
                }
                else
                {
                    if (imc > 20 && imc < 25)
                    {
                        situacao = " peso normal.";
                    }
                    else
                    {
                        if (imc >= 25)
                        {
                            situacao = " Acima do peso!";
                        }
                    }
                }
                Console.WriteLine("O IMC é:" + imc + " e você está " + situacao);
                Console.WriteLine("Quer continuar? (s/n)"); 
                continua = Console.ReadLine();
            }while(continua == "s");
        }







    }
}

