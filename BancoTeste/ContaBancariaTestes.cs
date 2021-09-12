using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banco;

namespace BancoTeste
{
    [TestClass]
    public class ContaBancariaTestes
    {
        [TestMethod]
        public void Debito_ComValorValido_AtualizaSaldo()
        {
            // arranjo
            double saldoInicial = 11.99;
            double valorDebito = 4.55;
            double saldoEsperado = 7.44;

            ContaBancaria conta = new ContaBancaria("Cristiano", saldoInicial);

            // debita
            conta.Debito(valorDebito);

            // assert
            double saldoAtual = conta.Saldo;
            Assert.AreEqual(saldoEsperado, saldoAtual, 0.001, "Conta não foi debitada corretamente");

        }
    }
}
