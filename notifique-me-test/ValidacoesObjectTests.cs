namespace JNogueira.NotifiqueMe.Test;
public class ObjExemplo
{
    public int Id { get; set; }

    public string Nome { get; set; }
}

public class ValidacoesObjectTests : Notificavel
{
    [Test]
    [Category("Object")]
    public void Deve_Notificar_Se_Nulo()
    {
        ObjExemplo obj = null;

        this.NotificarSeNulo(obj, "O objeto é nulo.");
            
        Assert.That(Invalido);
    }

    [Test]
    [Category("Object")]
    public void Deve_Notificar_Se_Nao_Nulo()
    {
        ObjExemplo obj = new();

        this.NotificarSeNaoNulo(obj, "O objeto é não nulo.");

        Assert.That(Invalido);
    }
}
