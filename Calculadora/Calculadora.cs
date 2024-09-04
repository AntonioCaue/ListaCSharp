using System;

namespace Calculadora
{
    class Calculadora
    {
        static void Main(string[] args)
        {   
            //Verificar loop
            bool verificacao=true;
            do{
                
                    Console.WriteLine("\n-------Escolha uma opção-------");
                    Console.WriteLine("1 - Somar\n"+
                                "2 - Subtrair\n"+
                                "3 - Multiplicar\n"+
                                "4 - Dividir\n"+
                                "5 - Resto de divisão\n"+
                                "6 - Resultado da Potenciação\n"+
                                "7 - Raiz Quadrada\n"+
                                "0 - Sair\n");
                    
                    Console.WriteLine("Digite aqui:");
                    string entrada3 = Console.ReadLine();
                    if(entrada3=="0"){
                        Console.WriteLine("Operação Encerrada!!!");
                        verificacao = false;
                        continue;
                    }

                    //Entradas e variavel auxiliar
                    Console.WriteLine("Digite o 1° valor:");
                    double numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o 2° valor:");
                    //double numero2 = Convert.ToDouble(Console.ReadLine());
                    double resultado;
                
                    if (!double.TryParse(Console.ReadLine(), out double numero2)){                        numero2=0.0;
                        //Console.WriteLine("Raiz quadrada");
                        numero2 = 0.0;
                    }

                    switch (entrada3){
                        case "1"://soma
                            resultado = numero1 + numero2;
                            Console.WriteLine("\nA some deu "+resultado);
                            Console.WriteLine("\nPressione Enter para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "2"://subtação
                            resultado = numero1 - numero2;
                            Console.WriteLine("\nA subtração deu "+resultado);
                            Console.WriteLine("\nPressione Enter para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                            
                        case "3"://multiplicacao
                            resultado = numero1 * numero2;
                            Console.WriteLine("\nA multiplicação deu "+resultado);
                            Console.WriteLine("\nPressione Enter para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                            
                        case "4"://divisao
                            resultado = numero1 / numero2;
                            if(numero2 == 0){
                                Console.WriteLine("\nNão é possível dividir por zero.\n");
                                continue;
                            }
                            
                            resultado = numero1 / numero2;
                            Console.WriteLine("\nA divisão deu "+resultado);
                            Console.WriteLine("\nPressione Enter para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "5"://resto de divisao
                            resultado = numero1 % numero2;
                            if(resultado == numero1){
                                resultado = 0;
                            }
                            Console.WriteLine("\nO resto de divisão deu "+resultado);
                            Console.WriteLine("\nPressione Enter para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "6"://base pelo expoente
                            resultado = Math.Pow(numero1, numero2);
                            Console.WriteLine("\nA base pelo expoente deu "+resultado);
                            Console.WriteLine("\nPressione Enter para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "7"://raiz quadrada
                            resultado = Math.Sqrt(numero1);
                            Console.WriteLine("\nA raiz quadrada deu "+resultado);
                            Console.WriteLine("\nPressione Enter para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "0":
                            Console.WriteLine("Saindo...");
                            // Pausa a execução até o usuário pressionar Enter
                            Console.WriteLine("\nPressione Enter para continuar...");
                            Console.ReadLine();
                            //Limpa tela
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("\n--------Opção invalida digite novamente--------\n");
                            Console.WriteLine("\nPressione Enter para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                            break;


                    }
            }while(verificacao);
            
        }
    }
}
