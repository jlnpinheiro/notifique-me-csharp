using JNogueira.Infraestrutura.NotifiqueMe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infraestrutura.Comum.Tests.Notificacoes
{
    [TestClass]
    public class ValidacoesBooleanTests : Notificavel
    {
        [TestMethod]
        [TestCategory("Boolean")]
        public void Deve_Notificar_Se_Verdadeiro()
        {
            var valor = true;

            this.NotificarSeVerdadeiro(valor, "O valor é verdadeiro.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("Boolean")]
        public void Deve_Notificar_Se_Falso()
        {
            var valor = false;

            this.NotificarSeFalso(valor, "O valor é false.");

            Assert.IsTrue(this.Invalido);
        }
    }
}
