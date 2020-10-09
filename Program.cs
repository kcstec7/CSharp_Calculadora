/*
    Karla Santos
    Exercício baseado na calculadora do curso "Fundamentos do C#" (balta.io),
    com melhorias aplicadas para melhor apresentação do código e funcionamento
    08/10/2020
*/
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(bool exibeNormal = true)
        {
            if (exibeNormal)
            {
                // Faz limpar a tela do terminal
                Console.Clear();

                Console.WriteLine("O que deseja fazer? ");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
            }
            else
            {
                Console.WriteLine("0 - Retornar ao menu");
            }

            Console.WriteLine("5 - Sair");
            Console.WriteLine("--------------------");
            Console.WriteLine("Informe uma opção: ");

            short opcao = Testar_RetornarShort(Console.ReadLine());

            switch (opcao)
            {
                case 0: Menu(); break;
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    Menu(false);
                    break;
            }

            Menu();
        }

        static short Testar_RetornarShort(string valorDigitado)
        {
            if (String.IsNullOrWhiteSpace(valorDigitado))
            {
                return 0;
            }
            else
            {
                return short.Parse(valorDigitado);
            }
        }

        static float Testar_RetornarFloat(string valorDigitado)
        {
            if (String.IsNullOrWhiteSpace(valorDigitado))
            {
                Console.WriteLine(" *** Nada informado, este valor será zero *** ");
                Console.WriteLine();

                return 0;
            }
            else
            {
                return float.Parse(valorDigitado);
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("--------------------");
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("--------------------");

            Console.WriteLine("Primeiro valor: ");
            float valor1 = Testar_RetornarFloat(Console.ReadLine()); // Faz ler a linha para armazenar o valor

            Console.WriteLine("Segundo valor: ");
            float valor2 = Testar_RetornarFloat(Console.ReadLine());

            float resultado = valor1 + valor2;

            Console.WriteLine();
            Console.WriteLine($"O resultado da soma é: {resultado}");
            // Outras formas possíveis:
            // Console.WriteLine("O resultado da soma é: " + resultado);
            // Console.WriteLine($"O resultado da soma é: {valor1 + valor2}");
            // Console.WriteLine("O resultado da soma é: " + (valor1 + valor2));

            Fechamento();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("----------------------------");
            Console.WriteLine("Subtração entre dois números");
            Console.WriteLine("----------------------------");

            Console.WriteLine("Primeiro valor: ");
            float valor1 = Testar_RetornarFloat(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = Testar_RetornarFloat(Console.ReadLine());

            Console.WriteLine();

            float resultado = valor1 - valor2;

            Console.WriteLine($"O resultado da subtração é {resultado}");

            Fechamento();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("-------");
            Console.WriteLine("Divisão");
            Console.WriteLine("-------");

            float valor1 = 0;
            float valor2 = 0;

            do
            {
                Console.WriteLine("Primeiro valor: ");
                valor1 = Testar_RetornarFloat(Console.ReadLine());

                if (valor1 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Informe um valor diferente de zero para realizar a divisão!");
                    Console.WriteLine();
                }

            } while (valor1 == 0);

            do
            {
                Console.WriteLine("Segundo valor: ");
                valor2 = Testar_RetornarFloat(Console.ReadLine());

                if (valor2 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Informe um valor diferente de zero para realizar a divisão!");
                    Console.WriteLine();
                }

            } while (valor2 == 0);

            Console.WriteLine();

            float resultado = valor1 / valor2;

            Console.WriteLine($"O resultado da divisão é {resultado}");

            Fechamento();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Multiplicação entre dois números");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Primeiro valor: ");
            float valor1 = Testar_RetornarFloat(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = Testar_RetornarFloat(Console.ReadLine());

            Console.WriteLine();

            float resultado = valor1 * valor2;

            Console.WriteLine($"O resultado da multiplicação é {resultado}");

            Fechamento();
        }

        static void Fechamento()
        {
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
            Console.ReadKey(); // Faz com que o programa não seja encerrado

            Menu();
        }

    }
}
