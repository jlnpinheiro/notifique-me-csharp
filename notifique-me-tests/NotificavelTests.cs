using JNogueira.NotifiqueMe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Infraestrutura.Comum.Tests.Notificacoes
{
    public class ClasseNotificavel : Notificavel
    {
        public string Propriedade1 { get; set; }

        public string Propriedade2 { get; set; }
    }

    [TestClass]
    public class NotificavelTests : Notificavel
    {
        [TestMethod]
        [TestCategory("Geral")]
        public void Deve_Adicionar_Notificacoes()
        {
            var obj = new ClasseNotificavel();

            obj.AdicionarNotificacao("Notificação 1");
            obj.AdicionarNotificacao("Notificação 2");

            Assert.IsTrue(obj.Notificacoes.Count == 2);
        }

        [TestMethod]
        [TestCategory("Geral")]
        public void Deve_Adicionar_Notificacoes_Com_Informacoes_Adicionais()
        {
            var obj = new ClasseNotificavel();

            obj.AdicionarNotificacao("Notificação 1", new Dictionary<string, string> { { "Info adicional 1", "Teste" }, { "Info adicional 2", "Teste" } });

            Assert.IsTrue(obj.Notificacoes.First().InformacoesAdicionais.Count == 2);
        }

        [TestMethod]
        [TestCategory("Geral")]
        public void Deve_Adicionar_Colecao_Notificacoes()
        {
            var lst = new List<Notificacao> { new Notificacao("Notificação 1"), new Notificacao("Notificação 2") };

            var obj = new ClasseNotificavel();

            obj.AdicionarNotificacoes(lst);

            Assert.IsTrue(obj.Notificacoes.Count == 2);
        }

        [TestMethod]
        [TestCategory("Geral")]
        public void Deve_Adicionar_Colecao_Notificacoes_Classe_Notificavel()
        {
            var obj1 = new ClasseNotificavel();

            obj1.AdicionarNotificacao("Notificação 1");

            var obj2 = new ClasseNotificavel();

            obj2.AdicionarNotificacao("Notificação 2");
            obj2.AdicionarNotificacao("Notificação 3");

            obj2.AdicionarNotificacoes(obj1);

            Assert.IsTrue(obj2.Notificacoes.Count == 3);
        }

        [TestMethod]
        [TestCategory("Geral")]
        public void Deve_Adicionar_Colecao_Notificacoes_Classes_Notificaveis()
        {
            var obj1 = new ClasseNotificavel();

            obj1.AdicionarNotificacao("Notificação 1");

            var obj2 = new ClasseNotificavel();

            obj2.AdicionarNotificacao("Notificação 2");
            obj2.AdicionarNotificacao("Notificação 3");

            var obj3 = new ClasseNotificavel();

            obj3.AdicionarNotificacao("Notificação 4");

            var obj4 = new ClasseNotificavel();

            obj4.AdicionarNotificacoes(obj1, obj2, obj3);

            Assert.IsTrue(obj4.Notificacoes.Count == 4);
        }

        [TestMethod]
        [TestCategory("Geral")]
        public void Deve_Realizar_Varias_Validacoes()
        {
            var obj = new ClasseNotificavel { Propriedade1 = "abc" };

            obj
                .NotificarSePossuirTamanhoDiferente(obj.Propriedade1, 2, "Notificação 1")
                .NotificarSeNuloOuVazio(obj.Propriedade2, "Notificação 2");

            Assert.IsTrue(obj.Notificacoes.Count == 2);
        }

        [TestMethod]
        [TestCategory("Geral")]
        public void Deve_Obter_Todas_Mensagens_Notificacoees()
        {
            var obj = new ClasseNotificavel { Propriedade1 = "abc" };

            obj
                .NotificarSePossuirTamanhoDiferente(obj.Propriedade1, 2, "Notificação 1")
                .NotificarSeNuloOuVazio(obj.Propriedade2, "Notificação 2");

            Assert.IsTrue(obj.Mensagens.Count == 2);
        }
    }
}
