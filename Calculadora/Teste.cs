using System;

namespace Calculadora
{
    class Calculadora
    {
        static void Main(string[] args)
        {   
            // Verificar loop
            bool verificacao = true;
            do
            {
                Console.WriteLine("\n-------Escolha uma opção-------");
                Console.WriteLine("1 - Somar\n" +
                                  "2 - Subtrair\n" +
                                  "3 - Multiplicar\n" +
                                  "4 - Dividir\n" +
                                  "5 - Resto de divisão\n" +
                                  "6 - Resultado da Potenciação\n" +
                                  "7 - Raiz Quadrada\n" +
                                  "0 - Sair\n");

                Console.WriteLine("Digite aqui:");
                string entrada3 = Console.ReadLine();

                if (entrada3 == "0")
                {
                    Console.WriteLine("Operação Encerrada!!!");
                    verificacao = false;
                    continue;
                }

                // Entradas e variável auxiliar
                Console.WriteLine("Digite o 1° valor:");
                if (!double.TryParse(Console.ReadLine(), out double numero1))
                {
                    Console.WriteLine("Formato inválido para o 1° valor.");
                    continue;
                }

                Console.WriteLine("Digite o 2° valor:");
                if (!double.TryParse(Console.ReadLine(), out double numero2))
                {
                    Console.WriteLine("Formato inválido para o 2° valor. Usando 0.0 como valor padrão.");
                    numero2 = 0.0;
                }

                double resultado;

                switch (entrada3)
                {
                    case "1": // Soma
                        resultado = numero1 + numero2;
                        Console.WriteLine($"\nA soma deu {resultado}");
                        break;

                    case "2": // Subtração
                        resultado = numero1 - numero2;
                        Console.WriteLine($"\nA subtração deu {resultado}");
                        break;

                    case "3": // Multiplicação
                        resultado = numero1 * numero2;
                        Console.WriteLine($"\nA multiplicação deu {resultado}");
                        break;

                    case "4": // Divisão
                        if (numero2 == 0)
                        {
                            Console.WriteLine("\nNão é possível dividir por zero.");
                        }
                        else
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine($"\nA divisão deu {resultado}");
                        }
                        break;

                    case "5": // Resto de divisão
                        if (numero2 == 0)
                        {
                            Console.WriteLine("\nNão é possível calcular o resto de divisão por zero.");
                        }
                        else
                        {
                            resultado = numero1 % numero2;
                            Console.WriteLine($"\nO resto da divisão deu {resultado}");
                        }
                        break;

                    case "6": // Potenciação
                        resultado = Math.Pow(numero1, numero2);
                        Console.WriteLine($"\nA potência deu {resultado}");
                        break;

                    case "7": // Raiz quadrada
                        if (numero1 < 0)
                        {
                            Console.WriteLine("\nNão é possível calcular a raiz quadrada de um número negativo.");
                        }
                        else
                        {
                            resultado = Math.Sqrt(numero1);
                            Console.WriteLine($"\nA raiz quadrada deu {resultado}");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Saindo...");
                        verificacao = false;
                        break;

                    default:
                        Console.WriteLine("\n--------Opção inválida, digite novamente--------");
                        break;
                }

                // Mensagem de continuação e limpeza de tela
                if (entrada3 != "0")
                {
                    Console.WriteLine("\nPressione Enter para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (verificacao);
        }
    }
}
