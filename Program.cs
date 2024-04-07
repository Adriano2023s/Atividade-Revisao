using System;

namespace Atividade_Revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loopMenu = true;

            while (loopMenu)
            {
                Console.WriteLine("Escolha uma atividade.");
                Console.WriteLine("Atividade 1: Programa impar ou par.");
                Console.WriteLine("Atividade 2: Atividade posto de combustível.");
                Console.WriteLine("Atividade 3: Programa leitura cartesiana.");
                Console.WriteLine("Atividade 4: Um programa que verifica se um número está dentro ou fora de um intervalo");
                Console.WriteLine("Opção 5: Programa nota fiscal");
                Console.WriteLine("Opção 6: Leitura de tempo de jogo.");
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Atividade 1:");

                        int n1;

                        Console.WriteLine("Digite um número");
                        n1 = int.Parse(Console.ReadLine());

                        if (n1 % 2 == 0)
                        {
                            Console.WriteLine($"O número: {n1}, é par.");
                        }
                        else
                        {
                            Console.WriteLine($"O número: {n1}, é impar.");
                        }
                        break;

                        case 2:
                        Console.WriteLine("Atividade 2:");

                        int gasolina = 0;
                        int diesel = 0;
                        int alcool = 0;
                        int gnv = 0;
                        int combustivel = 0;

                        while (combustivel <= 4)
                        {
                            Console.WriteLine("Informe o combustível:");
                            Console.WriteLine("Opção 1: gasolina");
                            Console.WriteLine("Opção 2: Diesel");
                            Console.WriteLine("Opção 3: Alcool");
                            Console.WriteLine("Opção 4: GNV");
                            combustivel = int.Parse(Console.ReadLine());

switch (combustivel)
                            {
                                case 1:
                                    gasolina++;
                                    Console.WriteLine($"O total de abastessimentos de gasolina foi de: {gasolina}");
                                    break;

                                    case 2:
                                    diesel++;
                                    Console.WriteLine($"O total de abastessimentos de diesel foi de: {diesel}");
                                    break;

                                case 3:
                                    alcool++;
                                    Console.WriteLine($"O total de abastessimentos de alcool foi de: {alcool}");
                                    break;

                                    case 4:
                                    gnv++;
                                    Console.WriteLine($"O total de abastessimentos de GNV foi de: {gnv}");
                                    break;

                                    case 5:
                                    Console.WriteLine("Muito obrigado por escolher nosso posto!");
                                    break;
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Atividade 3");

                        double x;
                        double y;

                        while (true)
                        {
                            Console.WriteLine("Digite o valor de x");
                            x = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o valor de y");
                            y = double.Parse(Console.ReadLine());

                            if (x > 0 && y > 0)
                            {
                                Console.WriteLine("Primeiro quadrante");
                            }
                            else if (x > 0 && y < 0)
                            {
                                Console.WriteLine("Segundo quadrante");
                            }
                            else if (x < 0 && y > 0)
                            {
                                Console.WriteLine("Terceiro quadrante");
                            }
                            else
                            {
                                Console.WriteLine("Quarto quadrante");
                                break;
                            }
                        }
                        break;

                        case 4:
                        Console.WriteLine("Atividade 4");

                        int f1;
                        int f2;

                        Console.WriteLine("Digite um número");
                        f1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite outro número");
                        f2 = int.Parse(Console.ReadLine());

                        for (int i = f1; i < f2; i++)
                        {
                            if (i >= 10 && i <= 20)
                            {
                                Console.WriteLine($"In, dentro: {i}");
                            }
                            else
                            {
                                Console.WriteLine($"Out, fora: {i}");
                            }
                        }
                        break;


                }
            }
        }
    }
}
