using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!\nBem Vindo à nossa Calculadora! \n");
            Console.WriteLine("Digite o número correspondente à qual operação você deseja: \n");
            Console.WriteLine("1- Adição: ");
            Console.WriteLine("2- Subtração: ");
            Console.WriteLine("3- Multiplicação: ");
            Console.WriteLine("4- Divisão: ");
            

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                    }
                    break;

                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }

                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }

                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Digite uma opção válida");
                        break;

                    }
            }

            Console.WriteLine("O número {0}, com o número {1}, tem como resultado: {2}", num1, num2, resultado);
            Console.ReadLine();
        }

        private static int Adicao(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        private static int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }

        private static int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }

        private static int Divisao(int num1, int num2) 
        {
            int resultado = num1 / num2;
            return resultado;
        }

        
    }
}
