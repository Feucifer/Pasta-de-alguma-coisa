using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string continuar;

            do
            {
                Console.Clear();
                Console.WriteLine("--- MENU DE CALCULOS ---");
                Console.WriteLine("1 - Calcular IMC (Com Classificacao)");
                Console.WriteLine("2 - Maior e Menor Numero");
                Console.WriteLine("3 - Par ou Impar");
                Console.WriteLine("4 - Equacao de 2 Grau");
                Console.WriteLine("5 - Fahrenheit para Celsius");
                Console.WriteLine("6 - Celsius para Fahrenheit");
                Console.WriteLine("-------------------------");
                Console.Write("Escolha uma opcao: ");

                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Write("Peso (kg): ");
                    double peso = double.Parse(Console.ReadLine());
                    Console.Write("Altura (ex: 1,75): ");
                    double altura = double.Parse(Console.ReadLine());

                    
                    double imc = peso / (altura * altura);
                    Console.WriteLine("Seu IMC e: " + imc.ToString("F2"));

                   
                    if (imc < 18.5)
                    {
                        Console.WriteLine("Status: Abaixo do peso ideal.");
                    }
                    else if (imc >= 18.5 && imc <= 24.9)
                    {
                        Console.WriteLine("Status: Voce esta no peso ideal!");
                    }
                    else
                    {
                        Console.WriteLine("Status: Acima do peso ideal.");
                    }
                }
                else if (opcao == "2")
                {
                    Console.Write("Digite o primeiro numero: ");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo numero: ");
                    int n2 = int.Parse(Console.ReadLine());

                    if (n1 > n2)
                        Console.WriteLine("Maior: " + n1 + " | Menor: " + n2);
                    else if (n2 > n1)
                        Console.WriteLine("Maior: " + n2 + " | Menor: " + n1);
                    else
                        Console.WriteLine("Os numeros sao iguais.");
                }
                else if (opcao == "3")
                {
                    Console.Write("Digite um numero: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                        Console.WriteLine("O numero e Par.");
                    else
                        Console.WriteLine("O numero e Impar.");
                }
                else if (opcao == "4")
                {
                    Console.Write("Valor de A: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Valor de B: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Valor de C: ");
                    double c = double.Parse(Console.ReadLine());

                    double delta = (b * b) - (4 * a * c);

                    if (delta < 0)
                    {
                        Console.WriteLine("Delta: " + delta + " (Nao existem raizes reais).");
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("x1 = " + x1.ToString("F2"));
                        Console.WriteLine("x2 = " + x2.ToString("F2"));
                    }
                }
                else if (opcao == "5")
                {
                    Console.Write("Fahrenheit: ");
                    double f = double.Parse(Console.ReadLine());
                    double resC = (f - 32) / 1.8;
                    Console.WriteLine("Resultado: " + resC.ToString("F2") + "°C");
                }
                else if (opcao == "6")
                {
                    Console.Write("Celsius: ");
                    double c = double.Parse(Console.ReadLine());
                    double resF = (c * 1.8) + 32;
                    Console.WriteLine("Resultado: " + resF.ToString("F2") + "°F");
                }
                else
                {
                    Console.WriteLine("Opcao Invalida!");
                }

                Console.WriteLine("\nDigite 'sim' para recomecar:");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "sim");



        }
    }
}
