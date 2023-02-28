using System;
using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;


            Console.Write("Qual o seu nome: ");
            string Titular = Console.ReadLine();

            Console.Write("Número conta: ");
            int NumConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Haverá depósito inicial: (S/N)");
            char Resposta = char.Parse(Console.ReadLine()) ;

            double quantia = 0;

            if (Resposta == 'S' || Resposta == 's')
            {
                Console.Write("Valor do depósito: ");
                quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria (Titular, NumConta, quantia);
            }
            else 
            {
                contaBancaria = new ContaBancaria(Titular, NumConta);
            }

            Console.WriteLine(contaBancaria);

            Console.Write("Depósito: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(quantia);

            Console.WriteLine("Dados atualizados: " + contaBancaria);

            Console.Write("Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(quantia);

            Console.WriteLine("Dados atualizados: " + contaBancaria);


        }
    }
}
