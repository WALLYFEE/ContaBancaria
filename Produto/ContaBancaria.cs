using System;
using System.Globalization;

namespace Produto
{
    internal class ContaBancaria
    {
        public string NomeTitular { get; private set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nomeTitular, int numeroConta)
        {
            NomeTitular = nomeTitular;
            NumeroConta = numeroConta;
        }

        public ContaBancaria(string nomeTitular, int numeroConta, double saldo) : this(nomeTitular, numeroConta)
        {
            Saldo = saldo;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            Saldo = Saldo - 5 - saque;
        }

        public override string ToString()
        {
            return "Titular: "
                + NomeTitular
                + ", Conta Nº"
                + NumeroConta
                + ", Saldo R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
