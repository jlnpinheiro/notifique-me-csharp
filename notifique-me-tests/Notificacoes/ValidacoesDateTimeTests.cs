using System;
using JNogueira.NotifiqueMe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infraestrutura.Comum.Tests.Notificacoes
{
    [TestClass]
    public class ValidacoesDateTimeTests : Notificavel
    {
        [TestMethod]
        [TestCategory("DateTime")]
        public void Deve_Notificar_Se_Maior_Que()
        {
            var valor = DateTime.Today;

            this.NotificarSeMaiorQue(valor, valor.AddDays(-1), "A data informada é maior que a data comparada.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("DateTime")]
        public void Deve_Notificar_Se_Maior_Ou_Igual_A()
        {
            var valor = DateTime.Today;

            this.NotificarSeMaiorOuIgualA(valor, valor, "A data informada é maior ou igual a data comparada.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("DateTime")]
        public void Deve_Notificar_Se_Menor_Que()
        {
            var valor = DateTime.Today;

            this.NotificarSeMenorQue(valor, valor.AddDays(1), "A data informada é menor que a data comparada.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("DateTime")]
        public void Deve_Notificar_Se_Menor_Ou_Igual_A()
        {
            var valor = DateTime.Today;

            this.NotificarSeMenorOuIgualA(valor, valor, "A data informada é menor ou igual a data comparada.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("DateTime")]
        public void Deve_Notificar_Se_Entre()
        {
            var valor = DateTime.Today;

            this.NotificarSeEntre(valor, valor, valor.AddDays(1), "A data informada está entre a data inicial e a data final comparada.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("DateTime")]
        public void Deve_Notificar_Se_Iguais()
        {
            var valor = DateTime.Today;

            this.NotificarSeIguais(valor, valor, "A data informada é igual a data comparada.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("DateTime")]
        public void Deve_Notificar_Se_Diferentes()
        {
            var valor = DateTime.Today;

            this.NotificarSeDiferentes(valor, valor.AddDays(1), "A data informada é diferente da data comparada.");

            Assert.IsTrue(this.Invalido);
        }
    }
}
