using JNogueira.NotifiqueMe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infraestrutura.Comum.Tests.Notificacoes
{
    public class ObjExemplo
    {
        public int Id { get; set; }

        public string Nome { get; set; }
    }

    [TestClass]
    public class ValidacoesObjectTests : Notificavel
    {
        [TestMethod]
        [TestCategory("Object")]
        public void Deve_Notificar_Se_Nulo()
        {
            ObjExemplo obj = null;

            this.NotificarSeNulo(obj, "O objeto é nulo.");
                
            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("Object")]
        public void Deve_Notificar_Se_Nao_Nulo()
        {
            ObjExemplo obj = new ObjExemplo();

            this.NotificarSeNaoNulo(obj, "O objeto é não nulo.");

            Assert.IsTrue(this.Invalido);
        }
    }
}
