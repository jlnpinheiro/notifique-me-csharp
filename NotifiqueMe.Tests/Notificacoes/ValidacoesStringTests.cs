using JNogueira.Infraestrutura.NotifiqueMe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infraestrutura.Comum.Tests.Notificacoes
{
    [TestClass]
    public class ValidacoesStringTests : Notificavel
    {
        [TestMethod]
        [TestCategory("String")]
        public void Deve_Notificar_Se_Nulo_Ou_Vazio()
        {
            var valor = string.Empty;

            this.NotificarSeNuloOuVazio(valor, "A string não pode ser nula ou vazia.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("String")]
        public void Deve_Notificar_Se_Nao_Nulo_Ou_Vazio()
        {
            var valor = "123";

            this.NotificarSeNaoNuloOuVazio(valor, "A string deve ser nula ou vazia.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("String")]
        public void Deve_Notificar_Se_Possuir_Tamanho_Superior()
        {
            var valor = "123";

            this.NotificarSePossuirTamanhoSuperiorA(valor, 2, "A string não deve possuir tamanho superior a 2.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("String")]
        public void Deve_Notificar_Se_Possuir_Tamanho_Inferior()
        {
            var valor = "123";

            this.NotificarSePossuirTamanhoInferiorA(valor, 4, "A string não deve possuir tamanho inferior a 4.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("String")]
        public void Deve_Notificar_Se_Possuir_Tamanho_Diferente()
        {
            var valor = "123";

            this.NotificarSePossuirTamanhoDiferente(valor, 2, "A string deve possuir tamanho igual a 2.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("String")]
        public void Deve_Notificar_Se_Nulo_Ou_Vazio_Ou_Possuir_Tamanho_Diferente()
        {
            var valor = "123";

            this
                .NotificarSeNuloOuVazio(valor, "A string não pode ser nula ou vazia.")
                .NotificarSePossuirTamanhoDiferente(valor, 2, "A string deve possuir o tamanho igual a 2.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("String")]
        public void Deve_Notificar_Se_Contem()
        {
            this.NotificarSeContem("Jorge Luiz Nogueira", "Luiz", "A string contém a string procurada.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("String")]
        public void Deve_Notificar_Se_Nao_Contem()
        {
            this.NotificarSeNaoContem("Jorge Luiz Nogueira", "Silva", "A string não contém a string procurada.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("String")]
        public void Deve_Notificar_Se_Iguais()
        {
            this.NotificarSeIguais("123", "123", "A string é igual a string comparada.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("String")]
        public void Deve_Notificar_Se_Diferentes()
        {
            this.NotificarSeDiferentes("123", "1234", "A string é diferente a string comparada.");
            
            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("String")]
        public void Deve_Notificar_Se_Email_Invalido()
        {
            this.NotificarSeEmailInvalido("jlnpinheiro@gmail", "O e-mail informado é inválido.");

            Assert.IsTrue(this.Invalido);
        }

        [TestMethod]
        [TestCategory("String")]
        public void Deve_Notificar_Se_Url_Invalida()
        {
            this.NotificarSeUrlInvalida("http:/www.sefaz.es.gov.br", "A URL informada é inválida.");

            Assert.IsTrue(this.Invalido);
        }
    }
}
