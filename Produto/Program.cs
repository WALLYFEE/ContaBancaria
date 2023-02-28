using System;
using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria();
            ContaBancaria contaBancaria1 = new ContaBancaria(0.0);


            Console.Write("Qual o seu nome: ");
            contaBancaria.NomeTitular = Console.ReadLine();

            Console.Write("Número conta: ");
            contaBancaria.NumeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Haverá depósito inicial: (S/N)");
            string Resposta = Console.ReadLine();



            if (Resposta == "S" || Resposta == "s")
            {
                Console.Write("Valor do depósito: ");
                contaBancaria.Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else 
            {
                contaBancaria.Saldo = contaBancaria1.Saldo;
            }

            Console.WriteLine(contaBancaria);

            Console.Write("Depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(quantia);

            Console.WriteLine("Dados atualizados: " + contaBancaria);

            Console.Write("Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(quantia);

            Console.WriteLine("Dados atualizados: " + contaBancaria);


        }
    }
}
