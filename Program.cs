using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        { 
            string nome;
            double Fahren;
            double Celsius = 97;

            ConsoleColor.
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
                                                            
            Console.Write("Digite o Valor de Fahrenheit: ");
            Fahren = double.Parse(Console.ReadLine());

            Celsius = (Fahren - 32) /1.8; 
            Console.WriteLine("resultado da conversão: {0}", Math.Round(Celsius));
            
            Console.WriteLine($"Obrigado!{nome}!");
            
           
        }

        





        }
    }

