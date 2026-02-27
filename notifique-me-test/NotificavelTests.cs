namespace JNogueira.NotifiqueMe.Test;

public class NotificavelTests : Notificavel
{
    [Test]
    [Category("Geral")]
    public void Deve_Adicionar_Notificacoes()
    {
        var obj = new ClasseNotificavel();

        obj.AdicionarNotificacao("Notificação 1");
        obj.AdicionarNotificacao("Notificação 2");

        Assert.That(obj.Notificacoes, Has.Count.EqualTo(2));
    }

    [Test]
    [Category("Geral")]
    public void Deve_Adicionar_Notificacoes_Com_Informacoes_Adicionais()
    {
        var obj = new ClasseNotificavel();

        obj.AdicionarNotificacao("Notificação 1", new Dictionary<string, string> { { "Info adicional 1", "Teste" }, { "Info adicional 2", "Teste" } }, "N001");

        Assert.That(obj.Notificacoes.First().InformacoesAdicionais, Has.Count.EqualTo(2));
    }

    [Test]
    [Category("Geral")]
    public void Deve_Adicionar_Colecao_Notificacoes()
    {
        var lst = new List<Notificacao> { new("Notificação 1", "N001"), new("Notificação 2", "N002") };

        var obj = new ClasseNotificavel();

        obj.AdicionarNotificacoes(lst);

        Assert.That(obj.Notificacoes, Has.Count.EqualTo(2));
    }

    [Test]
    [Category("Geral")]
    public void Deve_Adicionar_Colecao_Notificacoes_Classe_Notificavel()
    {
        var obj1 = new ClasseNotificavel();

        obj1.AdicionarNotificacao("Notificação 1", "N001");

        var obj2 = new ClasseNotificavel();

        obj2.AdicionarNotificacao("Notificação 2", "N002");
        obj2.AdicionarNotificacao("Notificação 3", "N003");

        obj2.AdicionarNotificacoes(obj1);

        Assert.That(obj2.Notificacoes, Has.Count.EqualTo(3));
    }

    [Test]
    [Category("Geral")]
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

        Assert.That(obj4.Notificacoes, Has.Count.EqualTo(4));
    }

    [Test]
    [Category("Geral")]
    public void Deve_Realizar_Varias_Validacoes()
    {
        var obj = new ClasseNotificavel { Propriedade1 = "abc" };

        obj.NotificarSePossuirTamanhoDiferente(obj.Propriedade1, 2, "Notificação 1")
           .NotificarSeNuloOuVazio(obj.Propriedade2, "Notificação 2");

        Assert.That(obj.Notificacoes, Has.Count.EqualTo(2));
    }

    [Test]
    [Category("Geral")]
    public void Deve_Obter_Todas_Mensagens_Notificacoees()
    {
        var obj = new ClasseNotificavel { Propriedade1 = "abc" };

        obj.NotificarSePossuirTamanhoDiferente(obj.Propriedade1, 2, "Notificação 1")
           .NotificarSeNuloOuVazio(obj.Propriedade2, "Notificação 2");

        Assert.That(obj.Mensagens, Has.Count.EqualTo(2));
    }
}

public class ClasseNotificavel : Notificavel
{
    public string Propriedade1 { get; set; }

    public string Propriedade2 { get; set; }
}