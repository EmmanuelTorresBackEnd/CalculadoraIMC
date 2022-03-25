using System;
using System.Globalization;

namespace CalculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, resultado;
            do
            {

                Console.Write("Digite o seu peso (Ex:00,00) :");
                peso = double.Parse(Console.ReadLine());


                Console.Write("Digite o seu altura (Ex:0,00) :");
                altura = double.Parse(Console.ReadLine());

                resultado = (peso / (altura * altura));
                

                if ((resultado > 1) && (resultado < 18.5))
                {
                    Console.WriteLine($"Peso abaixo do normal: { resultado.ToString("N2", new CultureInfo("pt-BR"))}");
                }
                else if ((resultado > 18.5) && (resultado < 25))
                {
                    Console.WriteLine($"Peso normal: { resultado.ToString("N2", new CultureInfo("pt-BR"))}");
                }
                else if ((resultado > 25) && (resultado < 30))
                {
                    Console.WriteLine($"Sobre o Peso: { resultado.ToString("N2", new CultureInfo("pt-BR"))}");
                }
                else if ((resultado > 30) && (resultado < 35))
                {
                    Console.WriteLine($"Grau de Obesidade I: { resultado.ToString("N2", new CultureInfo("pt-BR"))}");
                }
                else if ((resultado > 35) && (resultado < 40))
                {
                    Console.WriteLine($"Grau de Obesidade II: { resultado.ToString("N2", new CultureInfo("pt-BR"))}");
                }
                else if (resultado > 40)
                {
                    Console.WriteLine($"Grau de Obesidade III: { resultado.ToString("N2", new CultureInfo("pt-BR"))}");

                }
                else if (resultado < 1)
                {
                    Console.WriteLine($"Dados Inseridos de Maneira Invalida, Tente Novamente");
                }
                
            } while (resultado < 1);
            {
                Console.WriteLine($"Calculo realizado com Sucesso!");
            }


            Console.ReadKey();
        }

    }
}
