using System;
namespace Banco
{
    public class ContaBancaria
    {
        private string nomeCliente;
        private double saldo;
        private bool bloqueada = false;
        private ContaBancaria()
        {
        }
        public ContaBancaria(string nomeDoCliente, double saldoDaConta)
        {
            nomeCliente = nomeDoCliente;
            saldo = saldoDaConta;
        }
        public string NomeCliente
        {
            get { return nomeCliente; }
        }
        public double Saldo
        {
            get { return saldo; }
        }
        public void Debito(double valor)
        {
            if (bloqueada)
            {
                throw new Exception("Conta Bloqueada");
            }
            if (valor > saldo)
            {
                throw new ArgumentOutOfRangeException("valor maior que o saldo");
            }
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("valor menor que zero");
            }
            saldo -= valor;
        }
        public void Credito(double valor)
        {
            if (bloqueada)
            {
                throw new Exception("Conta bloqueada");
            }
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("valor menor que zero");
            }
            saldo += valor;
        }
        private void ContaBloqueada()
        {
            bloqueada = true;
        }
        private void ContaNaoBloqueada()
        {
            bloqueada = false;
        }
        public static void Main()
        {
            ContaBancaria ba = new ContaBancaria("Mr. Macoratti", 11.99);
            ba.Credito(5.77);
            ba.Debito(11.22);
            Console.WriteLine("O saldo atual é R${0}", ba.Saldo);
        }
    }
}