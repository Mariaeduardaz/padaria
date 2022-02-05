using System;

namespace padaria.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("padaria hotpao!");
            Console.WriteLine("quantidade de paes");

            double pao = double.Parse(Console.ReadLine());

            double valorpao = pao * 0.12;

            Console.WriteLine("quantidade de broas");

            double broas = double.Parse(Console.ReadLine());

            double valorbroas = broas * 1.50;

            double valortotal = valorbroas + valorpao;

            Console.WriteLine($"valor arrecadado de paes mais broas foi de R${valortotal}");

            double valor = valortotal * 0.10;

            Console.WriteLine($"o valor para se guardar ´poupança é de R${valor}");

            Console.ReadLine(); 

        }
    }
}
